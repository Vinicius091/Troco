double ValorCompra, ValorPago, Troco;

Console.WriteLine("---Calculo da Compra---");
Console.WriteLine();

Console.WriteLine("Valor da Compra");
ValorCompra = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Valor Pago");
ValorPago = Convert.ToDouble(Console.ReadLine());

Troco = ValorPago - ValorCompra;

Console.WriteLine($"Troco: R${Troco:N2}");