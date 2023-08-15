using AutoMapper;
using FluentValidation;
using SellTech.Application.Commons.Bases;
using SellTech.Application.Dtos.Proveedor.Request;
using SellTech.Application.Dtos.Proveedor.Response;
using SellTech.Application.Interfaces;
using SellTech.Domain.Entities;
using SellTech.Infrastructure.Commons.Bases.Request;
using SellTech.Infrastructure.Commons.Bases.Response;
using SellTech.Infrastructure.Persistences.Interfaces;
using SellTech.Utilities.Static;
using WatchDog;

namespace SellTech.Application.Services
{
    public class ProveedorApplication : IProveedorApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProveedorApplication(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponse<BaseEntityResponse<ProveedorResponseDto>>> ListProveedores(BaseFiltersRequest filters)
        {
            var response = new BaseResponse<BaseEntityResponse<ProveedorResponseDto>>();

            try
            {
                var proveedores = await _unitOfWork.Proveedor.ListProveedores(filters);

                if (proveedores is not null)
                {
                    response.IsSuccess = true;
                    response.Data = _mapper.Map<BaseEntityResponse<ProveedorResponseDto>>(proveedores);
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

        public async Task<BaseResponse<ProveedorByIdResponseDto>> ProveedorById(int pkTblPosProveedor)
        {
            var response = new BaseResponse<ProveedorByIdResponseDto>();

            try
            {
                var proveedor = await _unitOfWork.Proveedor.GetByIdAsync(pkTblPosProveedor);

                if (proveedor is not null)
                {
                    response.IsSuccess = true;
                    response.Data = _mapper.Map<ProveedorByIdResponseDto>(proveedor);
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

        public async Task<BaseResponse<bool>> RegisterProveedor(ProveedorRequestDto requestDto)
        {
            var response = new BaseResponse<bool>();
            try
            {
                /*var validationResult = await _validationRules.ValidateAsync(requestDto);

                if (!validationResult.IsValid)
                {
                    response.IsSuccess = false;
                    response.Message = ReplyMessage.MESSAGE_VALIDATE;
                    response.Errors = validationResult.Errors;
                    return response;
                }*/

                var proveedor = _mapper.Map<TblPosProveedor>(requestDto);
                response.Data = await _unitOfWork.Proveedor.RegisterAsync(proveedor);

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
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_EXCEPTION;
                WatchLogger.Log(ex.Message);
            }

            return response;
        }

        public async Task<BaseResponse<bool>> EditProveedor(int pkTblPosProveedor, ProveedorRequestDto requestDto)
        {
            var response = new BaseResponse<bool>();
            try
            {
                var proveedorById = await ProveedorById(pkTblPosProveedor);

                if (proveedorById.Data is null)
                {
                    response.IsSuccess = false;
                    response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
                    return response;
                }

                var proveedor = _mapper.Map<TblPosProveedor>(requestDto);
                proveedor.Id = pkTblPosProveedor;
                response.Data = await _unitOfWork.Proveedor.EditAsync(proveedor);

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

        public async Task<BaseResponse<bool>> RemoveProveedor(int pkTblPosProveedor)
        {
            var response = new BaseResponse<bool>();
            try
            {
                var proveedorById = await ProveedorById(pkTblPosProveedor);

                if (proveedorById.Data is null)
                {
                    response.IsSuccess = false;
                    response.Message = ReplyMessage.MESSAGE_QUERY_EMPTY;
                    return response;
                }

                response.Data = await _unitOfWork.Proveedor.RemoveAsync(pkTblPosProveedor);

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
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_EXCEPTION;
                WatchLogger.Log(ex.Message);
            }

            return response;
        }
    }
}
