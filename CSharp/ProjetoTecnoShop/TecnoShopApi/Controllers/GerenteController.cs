using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TecnoShop.Domain.EF;
using TecnoShop.Poco;
using TecnoShop.Service.Shop;

namespace TecnoShopApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/shop/[controller]")]
    [ApiController]
    public class GerenteController : ControllerBase
    {
        private GerenteServico service;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public GerenteController(TecnoShopContext context) : base()
        {
            this.service = new GerenteServico(context);
        }

        /// <summary>
        /// Lista todos os registros da tabela Gerente por Paginação.
        /// </summary>
        /// <param name="take"> Onde inicia os resultados da pesquisa. </param>
        /// <param name="skip"> Quantos registros serão retornados. </param>
        /// <returns> Todos os registros. </returns>
        [HttpGet]
        public ActionResult<List<GerentePoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<GerentePoco> lista = this.service.Listar(take, skip);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Listar todos os registros da tabela Gerente por código de Loja.
        /// </summary>
        /// <param name="lojcod"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorLoja/{lojcod:int}")]
        public ActionResult<List<GerentePoco>> GetByLoja(int lojcod)
        {
            try
            {
                List<GerentePoco> listaPoco = this.service.Consultar(est => est.CodigoLoja == lojcod).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        ///  Lista os registro usando a chave de Gerente.
        /// </summary>
        /// <param name="chave"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("{chave:int}")]
        public ActionResult<GerentePoco> GetById(int chave)
        {
            try
            {
                GerentePoco poco = this.service.PesquisarPelaChave(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Inclui um novo dado na tabela Gerente.
        /// </summary>
        /// <param name="poco"> Dados que será incluido. </param>
        /// <returns> Dados incluido. </returns>
        [HttpPost]
        public ActionResult<GerentePoco> Post([FromBody] GerentePoco poco)
        {
            try
            {
                GerentePoco novoPoco = this.service.Inserir(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Altera um dado existente na tabela Gerente.
        /// </summary>
        /// <param name="poco"> Altera o dado selecionado. </param>
        /// <returns> Altera o dado selecionado. </returns>
        [HttpPut]
        public ActionResult<GerentePoco> Put([FromBody] GerentePoco poco)
        {
            try
            {
                GerentePoco novoPoco = this.service.Alterar(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Exclui um registro existente no recurso, utilizando um id.
        /// </summary>
        /// <param name="chave"> Chave para localização. </param>
        /// <returns> Dado excluido por Id. </returns>
        [HttpDelete("{chave:int}")]
        public ActionResult<GerentePoco> DeleteById(int chave)
        {
            try
            {
                GerentePoco poco = this.service.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
