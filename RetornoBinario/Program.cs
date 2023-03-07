using System.Security.AccessControl;

int numero, coef, restodiv;
int[] bin = new int[8];
Console.Write("Informe o número para converter em binário: ");
numero = int.Parse(Console.ReadLine());

retornoBinario(numero);
int[] retornoBinario(int numero)
{
    for(int count = 0; count < bin.Length; count++)
    {
        bin[count] = numero % 2;
        numero = numero / 2;
    }
    return bin;
}
for(int count = bin.Length-1; count >= 0; count--)
{
    Console.Write(bin[count]);
}