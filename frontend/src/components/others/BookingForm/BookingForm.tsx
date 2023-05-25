import React, { useState, useContext } from "react";
import { AiFillStar } from "react-icons/ai";
import DatePicker from "react-datepicker";
import "react-datepicker/dist/react-datepicker.css";
import { PublicationContext } from "../../../context/PublicationContext";
import { CurrentUserContext } from "../../../context/CurrentUserContext";
import { postAPIHandler } from "../../../api/apiHandler";
import { getAPIHandler } from "../../../api/apiHandler";
import { IResponse } from "../../../types/types";

const BookingForm: React.FC = () => {
  const [startDate, setStartDate] = useState(new Date());
  const { user } = useContext(CurrentUserContext);

  const tomorrow = new Date();
  tomorrow.setDate(tomorrow.getDate() + 1);
  const [endDate, setEndDate] = useState(tomorrow);
  const { publication } = useContext(PublicationContext);
  const [totalPrice, setTotalPrice] = useState(publication?.price);

  const handleBooking = async () => {
    let price = 0;
    if (publication && publication.price) {
      price = (endDate.getDate() - startDate.getDate()) * publication.price;
    }
    setTotalPrice(price);

    const users = await getAPIHandler("/users");
    const res: IResponse= users.data as IResponse;
    const usersData = res.data as any;


    let userID = 0;

    console.log(usersData);
    for (let i = 0; i < usersData.length; i++) {
      if (usersData[i].firstName === user?.firstname) {
        userID = usersData[i].id;
      }
    }

    const booking = {
      customerId: userID,
      publicationId: publication?.id,
      bookingDate: new Date(),
      checkInDate: startDate,
      departureDate: endDate,
      pricePerDay: publication?.price,
      totalPrice: price,
      bookingStatus: "confirmed",
    }

   const postRes = await postAPIHandler("/bookings", booking);
    
   // if post request is successful alert
    if (postRes.status === 201) {
      alert("Booking successful!");
    }
    
  };

  const handlePriceChange = () => {
    let price = 0;
    if (publication && publication.price) {
      price = (endDate.getDate() - startDate.getDate()) * publication.price;
    }
    setTotalPrice(price);
  }

  return (
    <div className="rounded-md shadow-lg bg-white">
      <div className="flex flex-col p-6 border-b border-gray-200">
        <div className="flex items-center justify-between mb-4">
          <h2 className="text-3xl font-bold">
            ₺{publication?.price} {" "}
            <p className="text-sm text-gray-600 font-medium">per night</p>
          </h2>
          <div className="flex items-center space-x-1">
            <p className="text-lg text-gray-600 font-medium">4.9</p>
            <AiFillStar className="text-black-500 text-lg" />
          </div>
        </div>
        <div className="flex">
          <DatePicker
            selected={startDate}
            onChange={(date: any) => {handlePriceChange(); setStartDate(date);}}
            selectsStart
            startDate={startDate}
            endDate={endDate}
            dateFormat="dd/MM/yyyy"
            placeholderText="Check-in"
            className="w-full border-gray-200 rounded-md p-2 mr-2"
          />
          <DatePicker
            selected={endDate}
            onChange={(date: any) => {handlePriceChange(); setEndDate(date); }}
            selectsEnd
            startDate={startDate}
            endDate={endDate}
            dateFormat="dd/MM/yyyy"
            minDate={startDate}
            placeholderText="Check-out"
            className="w-full border-gray-200 rounded-md p-2"
          />
        </div>
        <button onClick={handleBooking} className="bg-green-500 text-white mt-5 py-3 rounded-md font-medium text-sm">
          Book
        </button>
        <p className="text-sm text-gray-600 text-center font-medium my-4">
          You won{`'`}t be charged yet
        </p>

        <div className="px-8 py-4 flex justify-between items-center border-t border-gray-200">
          <div className="flex flex-col space-y-2">
            <div className="text-sm text-gray-600 font-medium">Total:</div>
            <div className="text-lg font-bold">{totalPrice} ₺ </div>
            <div className="text-sm text-gray-600 font-medium">for the above booking</div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default BookingForm;
