function  Cadastro(event){
    var nomecad= document.getElementById("nome_cad");
    var emailcad= document.getElementById("email_cad");
    var senhacad= document.getElementById("senha_cad");
    var confirmasenhacad= document.getElementById("confirma_senha_cad");
    
  
    axios.post("https://localhost:44362/api/Usuario/cadastrarUsuario", {
        nome: nomecad.value,
        email: emailcad.value,
        senha: senhacad.value,
        ConfirmaSenha: confirmasenhacad.value 
      })
      .then(function (response) {
        console.log(response);
      })
      .catch(function (error) {
        console.log(error);
      });
      event.stopPropagation();     
  }