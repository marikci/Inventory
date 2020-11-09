import React from 'react';
import { Col, FormGroup, Label, Input } from 'reactstrap';
class CustomDropdown extends React.Component {
     
    render() {
        const {
            label,
            handleChange,
            values
        } = this.props;

        return (
            <FormGroup row>
                <Label for="exampleSelect" sm={4}>{ label } </Label>
                <Col sm={6}>
                    <Input type="select" name="select" id="exampleSelect" onChange={handleChange}>
                        {values.map(x =>
                            <option key={x.Id} value={x.Id}>{x.Text}</option>
                        )};
                </Input>
                </Col>
            </FormGroup>
        );
    }
}

export default CustomDropdown;