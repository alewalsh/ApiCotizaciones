import React, { Component } from 'react';

export class Cotizaciones extends Component {
    displayName = Cotizaciones.name;
    constructor(props) {
        super(props);
        var date = new Date().getDate(); //Current Date
        var month = new Date().getMonth() + 1; //Current Month
        var year = new Date().getFullYear(); //Current Year
        var hours = new Date().getHours(); //Current Hours
        var min = new Date().getMinutes(); //Current Minutes
        var sec = new Date().getSeconds(); //Current Seconds
        this.state = { data: [], loading: true, fecha: date + '/' + month + '/' + year + ' ' + hours + ':' + min + ':' + sec };
    }

    loadData() {
        var date = new Date().getDate(); //Current Date
        var month = new Date().getMonth() + 1; //Current Month
        var year = new Date().getFullYear(); //Current Year
        var hours = new Date().getHours(); //Current Hours
        var min = new Date().getMinutes(); //Current Minutes
        var sec = new Date().getSeconds(); //Current Seconds
        const xhr = new XMLHttpRequest();
        xhr.open('get', 'cotizaciones/all', true);
        xhr.onload = () => {
            const data = JSON.parse(xhr.responseText);
            this.setState({ data: data, loading: false, fecha: date + '/' + month + '/' + year + ' ' + hours + ':' + min + ':' + sec });
        };
        xhr.send();
    }

    componentDidMount() {
        this.loadData();
        window.setInterval(
            () => this.loadData(),
            5000,
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : <table className='table'>
                <thead>
                    <tr>
                        <th>Moneda</th>
                        <th>Precio</th>
                    </tr>
                </thead>
                <tbody>
                    {this.state.data.map(currency =>
                        <tr key={currency.moneda}>
                            <td style={{ textTransform: 'capitalize' }}>{currency.moneda}</td>
                            <td>{currency.precio}</td>
                        </tr>
                    )}
                </tbody>
            </table>;

        return (
            <div>
                <h1>Cotizaciones al dia de la fecha</h1>
                <p>Se muestran las cotizaciones del Dolar, Euro y Real al instante y con actualizaciones cada 5 segundos.</p>
                {contents}
                <p>Ultima actualizacion: {this.state.fecha}</p>
            </div>
        );
    }
}
