import React, { useState } from 'react';
import { AiFillStar } from 'react-icons/ai';
import DatePicker from 'react-datepicker';
import 'react-datepicker/dist/react-datepicker.css';

const BookingForm:React.FC = () => {
  const [startDate, setStartDate] = useState(new Date());
  const [endDate, setEndDate] = useState(new Date());

  return (
    <div className="rounded-md shadow-lg bg-white">
      <div className="flex flex-col p-6 border-b border-gray-200">
        <div className="flex items-center justify-between mb-4">
          <h2 className="text-3xl font-bold">₺9,499  <p className="text-sm text-gray-600 font-medium">per night</p></h2>
          <div className="flex items-center space-x-1">
            <p className="text-lg text-gray-600 font-medium">4.9</p>
            <AiFillStar className="text-black-500 text-lg" />
          </div>
        </div>
        <div className="flex">
          <DatePicker
            selected={startDate}
            onChange={(date:any) => setStartDate(date)}
            selectsStart
            startDate={startDate}
            endDate={endDate}
            dateFormat="dd/MM/yyyy"
            placeholderText="Check-in"
            className="w-full border-gray-200 rounded-md p-2 mr-2"
          />
          <DatePicker
            selected={endDate}
            onChange={(date:any) => setEndDate(date)}
            selectsEnd
            startDate={startDate}
            endDate={endDate}
            dateFormat="dd/MM/yyyy"
            minDate={startDate}
            placeholderText="Check-out"
            className="w-full border-gray-200 rounded-md p-2"
          />
        </div>
        <button className="bg-green-500 text-white mt-5 py-3 rounded-md font-medium text-sm">
                Book 
        </button>
        <p className="text-sm text-gray-600 text-center font-medium my-4">You won't be charged yet</p>

        <div className="px-8 py-4 flex justify-between items-center border-t border-gray-200">
            <div className="flex flex-col space-y-2">
            <div className="text-sm text-gray-600 font-medium">Total:</div>
            <div className="text-lg font-bold">₺9,499</div>
        </div> 
        </div>
      </div>
    </div>
    );
};

export default BookingForm;
