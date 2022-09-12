Console.Title = "Calculadora de Salário";

double pesoKg, pesoG, peso10;

string[] frase = new string[14];
frase[0] = "P";
frase[1] = "e";
frase[2] = "s";
frase[3] = "o";
frase[4] = " ";
frase[5] = "e";
frase[6] = "m";
frase[7] = " ";
frase[8] = "G";
frase[9] = "r";
frase[10] = "a";
frase[11] = "m";
frase[12] = "a";
frase[13] = "s";

Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.SetCursorPosition(5, 2);
Console.WriteLine("╔");
Console.SetCursorPosition(37, 2);
Console.WriteLine("╗");
Console.SetCursorPosition(5, 3);
Console.WriteLine("║                               ║");
Console.SetCursorPosition(5, 4);
Console.Write("╠");
Console.SetCursorPosition(37, 4);
Console.Write("╣");
Console.SetCursorPosition(5, 12);
Console.WriteLine("╚");
Console.SetCursorPosition(37, 12);
Console.WriteLine("╝");

for(int i = 0; i <= 30; i++){
    Console.SetCursorPosition(i+7,3);
    Console.SetCursorPosition(i+6,4);
    Console.Write("═");
    Console.SetCursorPosition(i+6,2);
    Console.Write("═");        
    Console.SetCursorPosition(i+6,12);
    Console.Write("═");
    Thread.Sleep(100);
}

for(int i = 0; i <= 6; i++){
    Console.SetCursorPosition(5, i+5);
    Console.WriteLine("║                               ║");
    Thread.Sleep(100);
}

for (int i = 0; i <= 13; i++){    
    Console.SetCursorPosition(i+14,3);
    Console.Write(frase[i]);
    Thread.Sleep(100);
}

Console.SetCursorPosition(6, 5);
Console.WriteLine("Digite seu peso em kilogramas: ");
Console.SetCursorPosition(6, 6);
pesoKg = Convert.ToDouble(Console.ReadLine().Replace(",","."));

pesoG = pesoKg * 1000;
peso10 = pesoG + 0.1*pesoG;

Console.SetCursorPosition(6, 7);
Console.WriteLine($"Peso em gramas: {pesoG:N2}g.");

Console.SetCursorPosition(6, 8);
Console.WriteLine($"Peso com +10%: {peso10:N2}g.");

Console.SetCursorPosition(6, 10);
Console.WriteLine("Pressione uma tecla p/ sair...");

Console.SetCursorPosition(0, 13);
Console.ReadKey();

Console.SetCursorPosition(6, 11);
Console.WriteLine("Obrigado! FATEC 2022/2");
Console.ResetColor();