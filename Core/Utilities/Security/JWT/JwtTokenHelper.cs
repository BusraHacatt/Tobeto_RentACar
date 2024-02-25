using Core.Entities;
using Core.Entities.Concrete;
using Core.Utilities.Security.Encriyption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public class JwtTokenHelper : ITokenHelper
    {
        private IConfiguration _configuration;
        private TokenOptions _tokenOptions;
        private readonly DateTime _expirationTime;
        public JwtTokenHelper(IConfiguration configuration)
        {
            _configuration = configuration;
            _tokenOptions = _configuration.GetSection("TokenOptions").Get<TokenOptions>();
        }

        //public AccessToken CreateToken(User user)
        //{
        // TODO: Refactor
        //DateTime expirationTime = DateTime.Now.AddMinutes(_tokenOptions.ExpirationTime);
        //SecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenOptions.SecurityKey));
        //SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);

        //JwtSecurityToken jwt = new JwtSecurityToken(
        //   issuer: _tokenOptions.Issuer,
        //   audience: _tokenOptions.Audience,
        //   expires: expirationTime,
        //   signingCredentials: signingCredentials,
        //   notBefore: DateTime.Now
        //  );
        //JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

        //string token = handler.WriteToken(jwt);


        //return new AccessToken()
        //{
        //    Token = token,
        //    ExpirationTime = expirationTime,
        //};
        //}
        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            DateTime expirationTime = DateTime.Now.AddMinutes(_tokenOptions.ExpirationTime);

            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            var signingCredentials = SigningCredentialHelper.CreateSigningCredentials(securityKey);
            var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, operationClaims);
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);
            return new AccessToken()
            {
                Token = token,
                ExpirationTime = expirationTime,

            };

        }


        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user,
          SigningCredentials signingCredentials, List<OperationClaim> operationClaims)
        {
            var jwt = new JwtSecurityToken(
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                expires: _expirationTime,
                notBefore: DateTime.Now,
                claims: SetClaims(user, operationClaims),
                signingCredentials: signingCredentials
            );
            return jwt;
        }

        private IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims)
        {
            throw new NotImplementedException();
        }











    }
}

