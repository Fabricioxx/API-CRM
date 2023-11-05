using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// JwtSettings para armazenar configurações relacionadas ao JWT como a chave secreta, emissor, público-alvo e duração do token.
namespace API_CRM.Auth
{
    public class JwtSettings
{
    public string SecretKey { get; set; }
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public int DurationInMinutes { get; set; }
}
}