import React from 'react';
import { Col, FormGroup, Label, Input } from 'reactstrap';
class CustomText extends React.Component {

    render() {
        const {
            value,
            label,
            handleChange,
            pattern
        } = this.props;

        return (
            <FormGroup row>
                <Label for="customText" sm={4}>{label} </Label>
                <Col sm={6}>
                    <Input type="text" name="text" required pattern={pattern} id="customText" value={value} onChange={handleChange} />
                </Col>
            </FormGroup>
        );
    }
}

export default CustomText;