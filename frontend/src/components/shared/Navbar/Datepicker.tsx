import React from 'react';
import DatePicker from "react-datepicker";
import "react-datepicker/dist/react-datepicker.css";

const Datepicker:React.FC = () => {
    const [startDate, setStartDate] = React.useState(new Date());

    return (    
        <div>
            <DatePicker selected={startDate} onChange={(date:any) => setStartDate(date)} />
        </div>
    )    
}

export default Datepicker

