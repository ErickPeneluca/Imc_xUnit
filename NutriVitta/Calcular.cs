namespace NutriVitta;

public class Calcular
{
    public static double CalcularImc(double peso, double altura)
    {
        double imc = peso / (altura * altura);
        return imc;
    }
}