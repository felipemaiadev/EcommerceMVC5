
const url = 'https://localhost:44353/'

function GetProductBySKU() {

  const response = fetch(`${url}/produto/GetListaProdutos`).then((value) => {
        return value.json();
    
    },
        (error) => console.error(error));

    response.then((value) => console.log(value))
}


function SalvarProduto() {

    const idSku = document.getElementById("SKU").value;
    const desc = document.getElementById("Descricao").value;
    const fabricante = document.getElementById("Fabricante").value;
    const valor = document.getElementById("Preco").value;


    const request = {
        SKU: idSku,
        Descricao: desc,
        Fabricante: fabricante,
        Preco: valor
    }

  const headers =   {
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
      method: "POST",
      body: JSON.stringify(request)
    }

    const response = fetch(`${url}produto/CadastrarProduto`, headers).then((response) => response.json());



}