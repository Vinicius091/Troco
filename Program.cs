double ValorCompra, ValorPago, Troco;

Console.WriteLine("---Calculo da Compra---");
Console.WriteLine();

Console.WriteLine("Valor da Compra");
Console.Write("Digite o valor da compra: ");
ValorCompra = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Valor Pago");
Console.Write("Digite o valor pago: ");
ValorPago = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Troco = ValorPago - ValorCompra;

Console.WriteLine($"Troco: R${Troco:N2}");