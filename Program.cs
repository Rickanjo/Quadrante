// Leia as coordenadas cartesianas (x, y) de um ponto informado pelo usuário.
Console.WriteLine("--- Localizando Ponto Plano Cartesiano ---\n");

Console.Write("Digite a coordenada x do ponto....: ");
double x = double.Parse(Console.ReadLine()!);

Console.Write("Digite a coordenada y do ponto....: ");
double y = double.Parse(Console.ReadLine()!);

if (x == 0 && y == 0) {
    Console.WriteLine("O ponto está na origem.");
}

else if (x != 0 && y == 0) {
    Console.WriteLine("O ponto está sobre o eixo x.");
}
else if (x == 0 && y != 0) {
    Console.WriteLine("o ponto está sobre o eixo y.");
}
else if (x> 0 && y >0) {
    Console.WriteLine("O ponto está no primeiro quadrante.");
}
else if (x < 0 && y > 0) {
    Console.WriteLine("O ponto está no segundo quadrante.");
}
else if (x < 0 && y < 0) {
    Console.WriteLine("o ponto está no terceiro quadrante.");
}
else if (x > 0 && y < 0) {
    Console.WriteLine("O ponto está no quarto quadrante.");
}


