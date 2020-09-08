namespace Init_onlyProperties
{
    public class Produto
    {
        public int Codigo { get; private set; }
        public string Descricao { get; private set; }

        public Produto(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }
    }
}