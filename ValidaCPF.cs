public class ValidaCPF
{
    public string cpf;

    public bool CalcularCPF (string cpf)
    {
        cpf = cpf.Replace(".", "").Replace("-", "");

        if (cpf.Length != 11)
        {
            return false;
        }

        int soma = 0;
        for(int i = 0; i < 9; i++)
        {
            int digito = int.Parse(cpf[i].ToString());
            soma = soma + digito * (10 - i);
        }

        int primeiroDijitoVerificador = 11 - (soma % 11);

        if (primeiroDijitoVerificador >= 10)
        {
            primeiroDijitoVerificador = 0;
        }

        if (int.Parse(cpf[9].ToString()) != primeiroDijitoVerificador)
        {
            return false;
        }

        soma = 0;

        for (int i = 0; i < 10; i++)
        {
            int digito = int.Parse(cpf[i].ToString());
            soma = soma + digito * (11 - i);
        }

        int segundoDigitoVerificador = 11 - ( soma % 11);

        if (segundoDigitoVerificador >= 10)
        {
            segundoDigitoVerificador = 0;
        }

        return int.Parse(cpf[10].ToString()) == segundoDigitoVerificador;
    }
}