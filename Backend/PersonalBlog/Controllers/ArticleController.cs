using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Dto;
using PersonalBlog.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonalBlog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private BlogContext _blogContext;
        public ArticleController(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Article> Get()
        {
            System.Threading.Thread.Sleep(5000);
            return _blogContext.Articles.ToList();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ActionResult<Article> Get(int id)
        {
            var article = _blogContext.Articles.FirstOrDefault(i => i.Id == id);
            if (article == null)
                return NotFound();
            return Ok(article);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{title}")]
        public ActionResult<List<Article>> GetArticlesByTitle(string title)
        {
            var articles = _blogContext.Articles.Where(i => i.Title.Contains(title)).ToList();
            if (articles.Count == 0)
                return NotFound();
            return Ok(articles);
        }

        // POST api/<ArticleController>
        [HttpPost]
        public IActionResult Post([FromBody] ArticleForPost article)
        {
            Article artForPost = new()
            {
                Content = article.Content,
                Date = article.Date,
                ImagePath = article.ImagePath,
                Title = article.Title,
                Summary = article.Summary,
            };
            _blogContext.Articles.Add(artForPost);
            _blogContext.SaveChanges();
            return Ok(artForPost.Id);
        }

        // PUT api/<ArticleController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ArticleForPut article)
        {

            Article art = _blogContext.Articles.FirstOrDefault(i => i.Id == id);
            art.Title = article.Title ?? art.Title;
            art.Content = article.Content ?? art.Content;
            art.Summary = article.Summary ?? art.Summary;
            if (article.Date != null)
                art.Date = article.Date;
            art.ImagePath = article.ImagePath ?? art.ImagePath;
            _blogContext.Articles.Update(art);
            _blogContext.SaveChanges();
            return NoContent();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Article art = _blogContext.Articles.FirstOrDefault(i => i.Id == id);
            _blogContext.Remove(art);
            _blogContext.SaveChanges();
            return Ok("Deleted");
        }
    }
}
