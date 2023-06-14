import React, { useEffect, useState, useContext } from "react";
import { getAPIHandler } from "../../api/apiHandler";
import { CurrentUserContext } from "../../context/CurrentUserContext";
import { IUser, IResponse } from "../../types/types";

const Bookings = () => {
    const { user } = useContext(CurrentUserContext);   
    const [bookings, setBookings] = useState<any[]>([]);

    useEffect(() => {
        const fetchBookings = async () => {
            const userRes = await getAPIHandler("/users/");
            const userResData: IResponse = userRes.data as IResponse;
            const userData: any = userResData.data as any;

            let currUser = null;
            // traversing over userData to find the current user object
            for (let i = 0; i < userData.length; i++) {
                if (userData[i]._id === user?.id) {
                    currUser = userData[i];
                    break;
                }
            }
            
            const bookingsRes = await getAPIHandler(`/bookings/`);
            const bookingsResData: IResponse = bookingsRes.data as IResponse;
            const bookingsData: any = bookingsResData.data as any;

            const currBookings = [];
            // traversing over bookingsData to find the current user's bookings
            for (let i = 0; i < bookingsData.length; i++) {
                if (bookingsData[i].customerId === currUser.id) {
                    currBookings.push(bookingsData[i]);
                }
            }
            
            setBookings(currBookings);
        };

        fetchBookings();
    }, []);

    return (
        <React.Fragment>
            <div className="mx-40 mt-10">
                <h1 className="text-3xl font-bold mb-4">Your Bookings</h1>
                {bookings.map((booking) => (
                    <div key={booking.id} className="border p-4 mb-4">
                        <h2 className="text-xl font-bold mb-2">
                            Booking ID: {booking.id}
                        </h2>
                        <p className="mb-2">
                            Date: { 
                                new Date(booking.bookingDate).toLocaleDateString()
                            }
                        </p>
                        <p>
                            Total Price: { booking.totalPrice }
                        </p>
                    </div>
                ))}
            </div>
        </React.Fragment>
    );
};

export default Bookings;