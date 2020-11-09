import React, { Component } from 'react';
import { Col } from 'reactstrap';
import CustomDropdown from './CustomDropdown';
import CustomText from './CustomText';

export class Home extends Component {
    static displayName = Home.name;

    constructor(props) {
        super(props);
        this.state = {
            softwareType: -1,
            softwareCompany: -1,
            softwareName: "",
            softwareTypes: [],
            softwareCompanies: [],
            count: "",
            cost: ""
        }
    }

    componentDidMount() {
        this.populateSoftwareTypes();
        this.populateSoftwareCompanies();

    }

    handleSelectSoftwareType = (event) => {
        this.setState({ softwareType: event.target.value });
    }

    handleSelectSoftwareCompany = (event) => {
        this.setState({ softwareCompany: event.target.value });
    }

    handleCountChange = (event) => {
        this.setState({ count: event.target.value });
    }

    handleCostChange = (event) => {
        this.setState({ cost: event.target.value });
    }

    handleSoftwareNameChange = (event) => {
        this.setState({ softwareName: event.target.value });
    }

    handleSaveChanges = (e) => {
        e.preventDefault();
        this.saveInventory();
    }

    render() {
        return (
            <div>
                <form name="inventoryForm" onSubmit={this.handleSaveChanges} ref={form => this.form = form}>
                    <Col sm={{ size: 6, offset: 3 }}>
                        <CustomDropdown label="Üretici Firma" values={this.state.softwareCompanies} value={this.state.softwareCompany} handleChange={this.handleSelectSoftwareCompany} />
                        <CustomDropdown label="Yazılım Tipi" values={this.state.softwareTypes} value={this.state.softwareType} handleChange={this.handleSelectSoftwareType} />
                        <CustomText label="Yazılım Adı" value={this.state.softwareName} handleChange={this.handleSoftwareNameChange} pattern=".*" />
                        <CustomText label="Adet" value={this.state.count} handleChange={this.handleCountChange} pattern="[0-9.]+" />
                        <CustomText label="Ücret" value={this.state.cost} handleChange={this.handleCostChange} pattern="[0-9.]+" />
                        <button className="btn btn-primary">Kaydet</button>
                    </Col>
                </form>
            </div>
        );
    }

    async populateSoftwareTypes() {
        const response = await fetch('http://localhost:53730/api/SoftwareType');
        const data = await response.json();
        this.setState({ softwareTypes: data, softwareType: data[0].Id });
    }

    async populateSoftwareCompanies() {
        const response = await fetch('http://localhost:53730/api/SoftwareCompany');
        const data = await response.json();
        this.setState({ softwareCompanies: data, softwareCompany: data[0].Id });
    }

    async saveInventory() {
        var item = {
            Piece: this.state.count,
            Fee: this.state.cost,
            SoftwareCompanyId: this.state.softwareCompany,
            SoftwareTypeId: this.state.softwareType,
            SoftwareName: this.state.softwareName
        };
        console.log(item);
        fetch('http://localhost:53730/api/Stock', {
            method: 'post',
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify(item)
        }).then((response) => {
            alert("Kayıt edilmiştir.");
        }).catch((err) => {
            alert(err);
        });
    }
}
