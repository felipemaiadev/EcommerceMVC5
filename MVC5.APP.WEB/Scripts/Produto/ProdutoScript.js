
const url = 'https://localhost:44353/'

function GetProductBySKU() {

  const response = fetch(`${url}/produto/GetListaProdutos`).then((value) => {
        return value.json();
    
    },
        (error) => console.error(error));

    response.then((value) => console.log(value))
}