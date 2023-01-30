using System.Text;

ConstrutorString();

static void FuncaoGuid()
{
    var id = Guid.NewGuid();
    id.ToString();

    id = new Guid("88b747ca-3091-44a4-9f05-39762632314d");

    id = new Guid();
    Console.WriteLine(id);
}

static void Interpolacao()
{
    var price = 10.2;
    // var texto = "O preco do produto e " + price + " apenas na promocao";
    // var texto = string.Format("O preco do produto e {0} apenas na promocao {1}", price, true);
    var texto = $@"O preco do 
    produto é {price} apenas na promocao";

    Console.WriteLine(texto);
}

static void Comparacao()
{
    var texto = "Testando";
    Console.WriteLine(texto.CompareTo("Testando"));
    Console.WriteLine(texto.CompareTo("testando"));

    texto = "Esse texto é um teste";
    Console.WriteLine(texto.Contains("teste"));
    Console.WriteLine(texto.Contains("Teste"));
    Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));
    Console.WriteLine(texto.Contains(null));
}

static void ComecaETerminaCom()
{
    var texto = "Este texto é um teste";
    Console.WriteLine(texto.StartsWith("Este"));
    Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));
    Console.WriteLine(texto.StartsWith("texto"));

    Console.WriteLine(texto.EndsWith("teste"));
    Console.WriteLine(texto.EndsWith("Teste"));
    Console.WriteLine(texto.EndsWith("xpto"));


}

static void IgualA()
{
    var texto = "Este texto é um teste";
    var teste = 33;

    Console.WriteLine(teste.Equals(32));
    Console.WriteLine(texto.Equals("Este texto é um teste"));
    Console.WriteLine(texto.Equals("este texto é um teste"));
    Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));
    
}

static void Indices()
{
    var texto = "Este texto é um teste";
    Console.WriteLine(texto.IndexOf("é"));
    Console.WriteLine(texto.LastIndexOf("s"));
}

static void UpAndLow()
{
    var texto = "Este texto é um teste";
    Console.WriteLine(texto.ToLower());
    Console.WriteLine(texto.ToUpper());
    Console.WriteLine(texto.Insert(5,"AQUI "));
    Console.WriteLine(texto.Remove(5, 5));
    Console.WriteLine(texto.Length);
}

static void Manipulate() 
{
    var texto = " Este texto é um teste";
    Console.WriteLine(texto.Replace("e", "X"));

    var divisao = texto.Split(" ");
    Console.WriteLine(divisao[0]);
    Console.WriteLine(divisao[1]);
    Console.WriteLine(divisao[2]);
    Console.WriteLine(divisao[3]);
    Console.WriteLine(divisao[4]);

    var resultado = texto.Substring(5, 5);
    Console.WriteLine(resultado);

    Console.WriteLine(texto.Trim());
}

static void ConstrutorString()
{
    var texto = new StringBuilder();
    texto.Append("Este texto é um teste");
    texto.Append("é um teste");
    texto.Append("Este texto");
    texto.Append("Este um teste");

    Console.WriteLine(texto);
}