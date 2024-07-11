using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TiendaMicroservicios.Api.Cupon.Data;
using TiendaMicroservicios.Api.Cupon.Models.Dto;

namespace TiendaMicroservicios.Api.Cupon.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CuponesController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private readonly ResponseDto _response;
        private readonly IMapper _mapper;

        public CuponesController(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _response = new ResponseDto();
            _mapper = mapper;
        }

        [HttpGet, Route("GetCupones")]
        public async Task<ResponseDto> Get()
        {
            try
            {
                IEnumerable<TiendaMicroservicios.Api.Cupon.Models.Cupon>
                    cupones = await _appDbContext.Cupons.ToListAsync();

                _response.Result = _mapper.Map<IEnumerable<CuponDto>>(cupones);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }


        [HttpGet, Route("GetCupon")]
        public async Task<ResponseDto> Get(int id)
        {
            try
            {
                TiendaMicroservicios.Api.Cupon.Models.Cupon
                    cupon = await _appDbContext.Cupons.FindAsync(id);

                _response.Result = _mapper.Map<CuponDto>(cupon);

                return _response;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return null;
        }



        [HttpGet, Route("getbycode")]
        public async Task<ResponseDto> GetByCode(string code)
        {
            try
            {
                TiendaMicroservicios.Api.Cupon.Models.Cupon
                    cupon = await _appDbContext.Cupons.SingleOrDefaultAsync(p => p.CuponCode.Equals(code));
                _response.Result = _mapper.Map<CuponDto>(cupon);
                return _response;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return null;
        }

        [HttpPost, Route("Crear")]
        public async Task<ResponseDto> Post([FromBody] CuponDto cuponDto)
        {
            try 
            {
                Cupon.Models.Cupon obj = _mapper.Map<Cupon.Models.Cupon>(cuponDto);
                _appDbContext.Cupons.Add(obj);
                await _appDbContext.SaveChangesAsync();
                _response.Result = _mapper.Map<CuponDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPut, Route("Actualizar")]
        public async Task<ResponseDto> Put([FromBody] CuponDto cuponDto)
        {
            try 
            {
                Cupon.Models.Cupon obj = _mapper.Map<Cupon.Models.Cupon>(cuponDto);
                _appDbContext.Cupons.Update(obj);
                await _appDbContext.SaveChangesAsync();
                _response.Result = _mapper.Map<CuponDto>(obj);
            } 
            catch (Exception ex) 
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }




    }
}
