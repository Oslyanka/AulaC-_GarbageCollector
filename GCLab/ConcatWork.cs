namespace GCLab;
 
// ===================================
// 4) Concatenação de string ineficiente
// ===================================
static class ConcatWork
{
    public static string Bad()
    {
        var sb = new System.Text.StringBuilder();
        for (int i = 0; i < 50_000; i++)
            sb.Append(i);
        return sb.ToString();
    }    
}
