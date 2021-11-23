namespace domain
{
    public class Email
    {
        public int Id { get; set; }
        public string Mensagem { get; set; }

        public DateTime DataInclusao { get; set; }

        public DateTime DataEnvio { get; set; }

    }
}