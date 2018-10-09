using System;

public class IMC
{

    private double massa;
    private double altura;
    private double calculou;

	public void IMC_(double massa, double altura)
	{

        this.massa = massa;
        this.altura = altura;

        this.calcular();
        this.classificar();

    }

    public double calcular()
    {

        this.calculou = this.massa / (this.altura * this.altura);
        Console.WriteLine("\nSeu IMC: {0}", this.calculou);

        return 0;

    }

    public double classificar()
    {

        if(this.calculou < 16)
        {
            Console.WriteLine("Magreza Grave.");
        }
        else if(this.calculou == 16 || this.calculou < 17)
        {
            Console.WriteLine("Magreza Moderada.");
        }
        else if(this.calculou == 17 || this.calculou < 18.5)
        {
            Console.WriteLine("Magreza Leve.");
        }
        else if (this.calculou == 18.5 || this.calculou < 25)
        {
            Console.WriteLine("Saudável.");
        }
        else if(this.calculou == 25 || this.calculou < 30)
        {
            Console.WriteLine("Sobrepeso.");
        }
        else if (this.calculou == 30 || this.calculou < 35)
        {
            Console.WriteLine("Obesidade Grau I.");
        }
        else if (this.calculou == 35 || this.calculou < 40)
        {
            Console.WriteLine("Obesidade Grau II. \n(SEVERA).");
        }
        else if (this.calculou > 30)
        {
            Console.WriteLine("Obesidade Grau III \n(MÓRBIDA).");
        }

        return 0;

    }
}
