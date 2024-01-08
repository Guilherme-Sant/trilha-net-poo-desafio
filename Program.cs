using DesafioPOO.Models;

// Implementado: Os testes com as classes Nokia e Iphone foram realizados com sucesso!
Nokia nokia1 = new Nokia("teste1");
Iphone iphone1 = new Iphone("teste2");

nokia1.InstalarAplicativo("NokiaAPP");
nokia1.ReceberLigacao();
nokia1.Ligar();
Console.WriteLine($"{nokia1.Numero}");
Console.WriteLine("                ");
Console.WriteLine("------------------------");
Console.WriteLine("                ");
iphone1.InstalarAplicativo("IphoneAPP");
iphone1.ReceberLigacao();
iphone1.Ligar();
Console.WriteLine($"{iphone1.Numero}");

