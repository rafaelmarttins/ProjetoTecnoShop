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
    public class EstoqueController : ControllerBase
    {
        private EstoqueServico service;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public EstoqueController(TecnoShopContext context) : base()
        {
            this.service = new EstoqueServico(context);
        }

        /// <summary>
        /// Lista todos os registros da tabela Estoque por Paginação.
        /// </summary>
        /// <param name="take"> Onde inicia os resultados da pesquisa. </param>
        /// <param name="skip"> Quantos registros serão retornados. </param>
        /// <returns> Todos os registros. </returns>
        [HttpGet]
        public ActionResult<List<EstoquePoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<EstoquePoco> lista = this.service.Listar(take, skip);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Listar todos os registros da tabela Estoque por código de Loja.
        /// </summary>
        /// <param name="lojcod"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorLoja/{lojcod:int}")]
        public ActionResult<List<EstoquePoco>> GetByLoja(int lojcod)
        {
            try
            {
                List<EstoquePoco> listaPoco = this.service.Consultar(est => est.CodigoLoja == lojcod).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        /// <summary>
        /// Listar todos os registros da tabela Estoque por código Produto.
        /// </summary>
        /// <param name="procod"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorProduto/{procod:int}")]
        public ActionResult<List<EstoquePoco>> GetByProduto(int procod)
        {
            try
            {
                List<EstoquePoco> listaPoco = this.service.Consultar(est => (est.CodigoProduto == procod)).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        ///  Lista os registro usando a chave da Estoque.
        /// </summary>
        /// <param name="chave"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("{chave:int}")]
        public ActionResult<EstoquePoco> GetById(int chave)
        {
            try
            {
                EstoquePoco poco = this.service.PesquisarPelaChave(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Inclui um novo dado na tabela Estoque.
        /// </summary>
        /// <param name="poco"> Dados que será incluido. </param>
        /// <returns> Dados incluido. </returns>
        [HttpPost]
        public ActionResult<EstoquePoco> Post([FromBody] EstoquePoco poco)
        {
            try
            {
                EstoquePoco novoPoco = this.service.Inserir(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Altera um dado existente na tabela Estoque.
        /// </summary>
        /// <param name="poco"> Altera o dado selecionado. </param>
        /// <returns> Altera o dado selecionado. </returns>
        [HttpPut]
        public ActionResult<EstoquePoco> Put([FromBody] EstoquePoco poco)
        {
            try
            {
                EstoquePoco novoPoco = this.service.Alterar(poco);
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
        public ActionResult<EstoquePoco> DeleteById(int chave)
        {
            try
            {
                EstoquePoco poco = this.service.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
