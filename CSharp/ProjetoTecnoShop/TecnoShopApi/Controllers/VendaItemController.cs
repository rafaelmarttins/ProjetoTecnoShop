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
    public class VendaItemController : ControllerBase
    {
        private VendaItemServico service;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public VendaItemController(TecnoShopContext context) : base()
        {
            this.service = new VendaItemServico(context);
        }

        /// <summary>
        /// Lista todos os registros da tabela Venda Item por Paginação.
        /// </summary>
        /// <param name="take"> Onde inicia os resultados da pesquisa. </param>
        /// <param name="skip"> Quantos registros serão retornados. </param>
        /// <returns> Todos os registros. </returns>
        [HttpGet]
        public ActionResult<List<VendaItemPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<VendaItemPoco> lista = this.service.Listar(take, skip);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Listar todos os registros da tabela Venda Item por código de Venda.
        /// </summary>
        /// <param name="vencod"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorVenda/{vencod:int}")]
        public ActionResult<List<VendaItemPoco>> GetByVenda(int vencod)
        {
            try
            {
                List<VendaItemPoco> listaPoco = this.service.Consultar(ven => ven.CodigoVenda == vencod).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        /// <summary>
        /// Listar todos os registros da tabela Venda Item por código Produto.
        /// </summary>
        /// <param name="procod"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorProduto/{procod:int}")]
        public ActionResult<List<VendaItemPoco>> GetByProduto(int procod)
        {
            try
            {
                List<VendaItemPoco> listaPoco = this.service.Consultar(ven => (ven.CodigoProduto == procod)).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        ///  Lista os registro usando a chave da Venda Item.
        /// </summary>
        /// <param name="chave"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("{chave:int}")]
        public ActionResult<VendaItemPoco> GetById(int chave)
        {
            try
            {
                VendaItemPoco poco = this.service.PesquisarPelaChave(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Inclui um novo dado na tabela Venda Item.
        /// </summary>
        /// <param name="poco"> Dados que será incluido. </param>
        /// <returns> Dados incluido. </returns>
        [HttpPost]
        public ActionResult<VendaItemPoco> Post([FromBody] VendaItemPoco poco)
        {
            try
            {
                VendaItemPoco novoPoco = this.service.Inserir(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Altera um dado existente na tabela Venda Item.
        /// </summary>
        /// <param name="poco"> Altera o dado selecionado. </param>
        /// <returns> Altera o dado selecionado. </returns>
        [HttpPut]
        public ActionResult<VendaItemPoco> Put([FromBody] VendaItemPoco poco)
        {
            try
            {
                VendaItemPoco novoPoco = this.service.Alterar(poco);
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
        public ActionResult<VendaItemPoco> DeleteById(int chave)
        {
            try
            {
                VendaItemPoco poco = this.service.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
