
const url = 'https://localhost:44353/'

function GetProductBySKU() {

    fetch(`${url}/produto/GetListaProdutos`).then((value) => {
        console.log(value.json());
    
    },
        (error) => console.error(error));
    
}