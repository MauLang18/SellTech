using AutoMapper;
using SellTech.Application.Commons.Bases;
using SellTech.Application.Dtos.Categoria.Request;
using SellTech.Application.Dtos.Categoria.Response;
using SellTech.Application.Interfaces;
using SellTech.Application.Validators.Categoria;
using SellTech.Domain.Entities;
using SellTech.Infrastructure.Commons.Bases.Request;
using SellTech.Infrastructure.Commons.Bases.Response;
using SellTech.Infrastructure.Persistences.Interfaces;
using SellTech.Utilities.Static;
using WatchDog;

namespace SellTech.Application.Services
{
    public class CategoriaApplication : ICategoriaApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly CategoriaValidator _validationRules;

        public CategoriaApplication(IUnitOfWork unitOfWork, IMapper mapper, CategoriaValidator validationRules)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validationRules = validationRules;
        }

        public async Task<BaseResponse<BaseEntityResponse<CategoriaResponseDto>>> ListCategorias(BaseFiltersRequest filters)
        {
            var response = new BaseResponse<BaseEntityResponse<CategoriaResponseDto>>();
            try
            {
                var categorias = await _unitOfWork.Categoria.ListCategorias(filters);

                if (categorias is not null)
                {
                    response.IsSuccess = true;
                    response.Data = _mapper.Map<BaseEntityResponse<CategoriaResponseDto>>(categorias);
                    response.Message = ReplyMessage.MESSAGE_QUERY;
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
                }
            } catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_EXCEPTION;
                WatchLogger.Log(ex.Message);
            }

            return response;
        }

        public async Task<BaseResponse<IEnumerable<CategoriaSelectResponseDto>>> ListSelectCategorias()
        {
            var response = new BaseResponse<IEnumerable<CategoriaSelectResponseDto>>();
            try
            {
                var categorias = await _unitOfWork.Categoria.GetAllAsync();

                if (categorias is not null)
                {
                    response.IsSuccess = true;
                    response.Data = _mapper.Map<IEnumerable<CategoriaSelectResponseDto>>(categorias);
                    response.Message = ReplyMessage.MESSAGE_QUERY;
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
                }
            }catch(Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_EXCEPTION;
                WatchLogger.Log(ex.Message);
            }

            return response;
        }
        public async Task<BaseResponse<CategoriaResponseDto>> CategoriaById(int pkTblPosCategoria)
        {
            var response = new BaseResponse<CategoriaResponseDto>();
            try
            {
                var categoria = await _unitOfWork.Categoria.GetByIdAsync(pkTblPosCategoria);

                if (categoria is not null)
                {
                    response.IsSuccess = true;
                    response.Data = _mapper.Map<CategoriaResponseDto>(categoria);
                    response.Message = ReplyMessage.MESSAGE_QUERY;
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_EXCEPTION;
                WatchLogger.Log(ex.Message);
            }

            return response;
        }

        public async Task<BaseResponse<bool>> RegisterCategoria(CategoriaRequestDto requestDto)
        {
            var response = new BaseResponse<bool>();
            try
            {
                var validationResult = await _validationRules.ValidateAsync(requestDto);

                if (!validationResult.IsValid)
                {
                    response.IsSuccess = false;
                    response.Message = ReplyMessage.MESSAGE_VALIDATE;
                    response.Errors = validationResult.Errors;
                    return response;
                }

                var categoria = _mapper.Map<TblPosCategorium>(requestDto);
                response.Data = await _unitOfWork.Categoria.RegisterAsync(categoria);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = ReplyMessage.MESSAGE_SAVE;
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = ReplyMessage.MESSAGE_FAILED;
                }
            }catch(Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_EXCEPTION;
                WatchLogger.Log(ex.Message);
            }

            return response;
        }

        public async Task<BaseResponse<bool>> EditCategoria(int pkTblPosCategoria, CategoriaRequestDto requestDto)
        {
            var response = new BaseResponse<bool>();
            try
            {
                var categoriaEdit = await CategoriaById(pkTblPosCategoria);

                if (categoriaEdit.Data is null)
                {
                    response.IsSuccess = false;
                    response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
                    return response;
                }

                var categoria = _mapper.Map<TblPosCategorium>(requestDto);
                categoria.Id = pkTblPosCategoria;
                response.Data = await _unitOfWork.Categoria.EditAsync(categoria);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = ReplyMessage.MESSAGE_UPDATE;
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = ReplyMessage.MESSAGE_FAILED;
                }
            }catch(Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_EXCEPTION;
                WatchLogger.Log(ex.Message);
            }

            return response;
        }

        public async Task<BaseResponse<bool>> RemoveCategoria(int pkTblPosCategoria)
        {
            var response = new BaseResponse<bool>();
            try
            {
                var categoria = await CategoriaById(pkTblPosCategoria);

                if (categoria.Data is null)
                {
                    response.IsSuccess = false;
                    response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
                    return response;
                }

                response.Data = await _unitOfWork.Categoria.RemoveAsync(pkTblPosCategoria);

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = ReplyMessage.MESSAGE_DELETE;
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = ReplyMessage.MESSAGE_FAILED;
                }
            }catch(Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_EXCEPTION;
                WatchLogger.Log(ex.Message);
            }

            return response;
        }
    }
}
