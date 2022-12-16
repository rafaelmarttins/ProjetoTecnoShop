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
    public class VendaController : ControllerBase
    {
        private VendaServico service;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public VendaController(TecnoShopContext context) : base()
        {
            this.service = new VendaServico(context);
        }

        /// <summary>
        /// Lista todos os registros da tabela Venda por Paginação.
        /// </summary>
        /// <param name="take"> Onde inicia os resultados da pesquisa. </param>
        /// <param name="skip"> Quantos registros serão retornados. </param>
        /// <returns> Todos os registros. </returns>
        [HttpGet]
        public ActionResult<List<VendaPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<VendaPoco> lista = this.service.Listar(take, skip);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Listar todos os registros da tabela Venda por código de Loja.
        /// </summary>
        /// <param name="lojcod"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorLoja/{lojcod:int}")]
        public ActionResult<List<VendaPoco>> GetByLoja(int lojcod)
        {
            try
            {
                List<VendaPoco> listaPoco = this.service.Consultar(ven => ven.CodigoLoja == lojcod).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        /// <summary>
        /// Listar todos os registros da tabela Venda por código Cliente.
        /// </summary>
        /// <param name="clicod"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorCliente/{clicod:int}")]
        public ActionResult<List<VendaPoco>> GetByCliente(int clicod)
        {
            try
            {
                List<VendaPoco> listaPoco = this.service.Consultar(ven => (ven.CodigoCliente == clicod)).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Listar todos os registros da tabela Venda por código Funcionário.
        /// </summary>
        /// <param name="funcod"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorFuncionario/{funcod:int}")]
        public ActionResult<List<VendaPoco>> GetByFuncionario(int funcod)
        {
            try
            {
                List<VendaPoco> listaPoco = this.service.Consultar(ven => (ven.CodigoFuncionario == funcod)).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        ///  Lista os registro usando a chave da Venda.
        /// </summary>
        /// <param name="chave"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("{chave:int}")]
        public ActionResult<VendaPoco> GetById(int chave)
        {
            try
            {
                VendaPoco poco = this.service.PesquisarPelaChave(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Inclui um novo dado na tabela Venda.
        /// </summary>
        /// <param name="poco"> Dados que será incluido. </param>
        /// <returns> Dados incluido. </returns>
        [HttpPost]
        public ActionResult<VendaPoco> Post([FromBody] VendaPoco poco)
        {
            try
            {
                VendaPoco novoPoco = this.service.Inserir(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Altera um dado existente na tabela Venda.
        /// </summary>
        /// <param name="poco"> Altera o dado selecionado. </param>
        /// <returns> Altera o dado selecionado. </returns>
        [HttpPut]
        public ActionResult<VendaPoco> Put([FromBody] VendaPoco poco)
        {
            try
            {
                VendaPoco novoPoco = this.service.Alterar(poco);
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
        public ActionResult<VendaPoco> DeleteById(int chave)
        {
            try
            {
                VendaPoco poco = this.service.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
   

