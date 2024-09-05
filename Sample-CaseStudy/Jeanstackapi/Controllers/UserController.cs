using Jeanstackapi.Entities;
using Jeanstackapi.models;
using Jeanstackapi.Repositiries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Jeanstackapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
    private readonly UserInterface _UserModel;

        IConfiguration configuration;
        public UserController(UserInterface userModel, IConfiguration configuration)
        {
            this._UserModel = userModel;
            this.configuration = configuration;
        }

       

        private string GetToken(User user)
        {
            var issuer = configuration["Jwt:Issuer"];
            var audience = configuration["Jwt:Audience"];
            var key = Encoding.UTF8.GetBytes(configuration["Jwt:Key"]);
            //header part
            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha512Signature
            );
            //payload part
            var subject = new ClaimsIdentity(new[]
            {
                        new Claim(ClaimTypes.Name,user.username),
                        new Claim(ClaimTypes.Role, user.type),
                        new Claim(ClaimTypes.Email,user.email),
                    });

            var expires = DateTime.UtcNow.AddMinutes(10);
            //signature part
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = subject,
                Expires = expires,
                Issuer = issuer,
                Audience = audience,
                SigningCredentials = signingCredentials
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = tokenHandler.WriteToken(token);
            return jwtToken;
        }

        [HttpPost,Route("/user/login")]
        [AllowAnonymous]
        public IActionResult loginUser(Login user)
        {
            try
            {
                var result=_UserModel.login(user.username,user.password);
               LoginResponse jsonResponse = new LoginResponse();
                if (result != null)
                    if(result.password == user.password)
                    {
                            
                            jsonResponse.userId = result.userId;
                            jsonResponse.username = result.username;
                            jsonResponse.type = result.type;
                            jsonResponse.email = result.email;
                            jsonResponse.token = GetToken(result);
                            
                        return StatusCode(200, new { ok = true, data = jsonResponse });
                    }
                    else
                    {
                        return Ok(new {ok= false,err="invalid password"});
                    }
                else
                    return Ok(new { msg = "Invalid username or password", ok = false });
            }
            catch (Exception ex)
            {
                return Ok (new { msg= ex.Message,ok=false});
            }
        }

        [HttpPost,Route("/user/signup")]
        [AllowAnonymous]
        public IActionResult signUpUser(User user) {
            try
            {
                _UserModel.signUp(user);
                return Ok("New user created");

            }catch(Exception ex)
            {
                return Ok(ex.Message);
            }

        }
        [HttpPut,Route("/user/editProfile")]
        [Authorize(Roles ="admin,customer")]
        public IActionResult editUserProfile(Profile user)
        {
            try
            {
                var user2=_UserModel.editProfile(user);
                return Ok(user2);

            }catch(Exception ex)
            {
                return Ok(ex.Message);
            }
        }
        [HttpPut,Route("/user/update-password")]
        [AllowAnonymous]
        public IActionResult updateUserPassword(Password password)
        {
            try
            {
                _UserModel.updatePassword(password.email,password.old_password,password.new_password);
                return Ok("password updated");
            }catch( Exception ex)
            {
                return Ok(ex.Message);
            }
        }

    }
}
