
const url = 'https://localhost:44353/'

function GetProductBySKU() {

    fetch(`${url}/produto/GetProductBySku`).then((value) => {
        console.log(value.json());

    },
        (error) => console.error(error));
    
}