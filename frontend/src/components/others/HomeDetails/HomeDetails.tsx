import React, { useContext, useEffect } from "react";
import { SlCalender } from "react-icons/sl";
import { MdWorkOutline } from "react-icons/md";
import { PublicationContext } from "../../../context/PublicationContext";
import { getAPIHandler } from "../../../api/apiHandler";
import ApplianceDetails from "./ApplianceDetails";

interface IResponse {
  data: any;
  errors: string[] | null;
}

const HomeDetails: React.FC = () => {
  const { publication, property } = useContext(PublicationContext);
  const [user, setUser] = React.useState<string>("User");

  useEffect(() => {
    const fetchData = async () => {
      try {
        const getUser = await getAPIHandler(
          "/users/" + property?.ownerId
        );
        const getUserRes: IResponse = getUser.data as IResponse;
        setUser(getUserRes.data.firstName);
      } catch (error) {
        console.log(error);
      }
    }
    fetchData();
  }, []);

  return (
    <React.Fragment>
      <div className="flex flex-col border-b pb-8 border-gray-200">
        <div className="flex border-b border-gray-200 justify-between">
          <h2 className="text-2xl font-bold py-2">Hosted by {user}</h2>
          <img
            src="https://via.placeholder.com/150"
            alt="Host avatar"
            className="rounded-full h-10 w-10"
          />
        </div>

        <div className="flex mt-6">
          <MdWorkOutline className="text-2xl text-gray-500" />
          <h4 className="text-2xs px-2 font-bold">Dedicated workspace</h4>
        </div>
        <p className="px-8">A room which fits your needs</p>

        <div className="flex mt-6">
          <SlCalender className="text-2xl  text-gray-500" />
          <p className="font-bold px-2">
            {" "}
            Free cancellation until 2 days before check-in
          </p>
        </div>
      </div>
      <div className="flex flex-col border-b pb-8 border-gray-200">
        <div className="flex mt-6">
          <p className="px-2">
            Every booking includes free protection from Host cancellations,
            listing inaccuracies, and other issues like trouble checking in.
          </p>
        </div>
      </div>
      <div className="flex flex-col border-b pb-8 border-gray-200">
        <div className="flex mt-6">
          <p className="px-2">{publication?.description}</p>
        </div>
      </div>


    </React.Fragment>
  );
};

export default HomeDetails;
