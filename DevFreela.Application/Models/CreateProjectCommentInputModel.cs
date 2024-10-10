namespace DevFreela.Application.Models
{
    public class CreateProjectCommentInputModel
    {
        public string Content { get; set; }
        public int IdProject { get; set; }
        public int IdUser { get; set; }
    }
}


// Alterar o tipo dos Ids para Guid "Id = Guid.NewGuid()"