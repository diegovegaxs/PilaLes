using pilales;

PilaLES p = new PilaLES();

p.Push("Hola");
Console.WriteLine(p.ToString());
p.Push("Mundo");
Console.WriteLine(p.ToString());
p.Push("C#");
Console.WriteLine(p.ToString());
Console.WriteLine("Se eliminó: " + p.Pop());
Console.WriteLine(p.ToString());
Console.WriteLine("El último elemento es: " + p.Top());
Console.WriteLine("La cantidad de elementos son: " + p.Size());
p.Push("Cómo");
Console.WriteLine(p.ToString());
p.Push("Están");
Console.WriteLine(p.ToString());
Console.WriteLine("¿La lista está vacia?: "+ p.Empty());
