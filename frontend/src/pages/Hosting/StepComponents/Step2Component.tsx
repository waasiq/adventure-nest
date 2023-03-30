import React from 'react';
import { FaHome, FaMapMarkerAlt, FaUsers } from 'react-icons/fa';

const Step2Component:React.FC = () => {
    return (    
        <React.Fragment>
            <h1 className='text-4xl font-bold mb-4'>Which best describes your home?</h1>
            <div className="grid grid-cols-3 gap-8">
                <div className="flex flex-col items-center cursor-pointer border-yellow-500	  bg-orange-900">
                    <FaHome size={48} />
                    <span className="mt-2 font-bold">Your Home</span>
                </div>
                <div className="flex flex-col items-center cursor-pointer">
                    <FaMapMarkerAlt size={48} />
                    <span className="mt-2 font-bold">Location</span>
                </div>
                <div className="flex flex-col items-center cursor-pointer">
                    <FaUsers size={48} />
                    <span className="mt-2 font-bold">Guests</span>
                </div>
                {/* add more grid items as needed */}
                </div>
        </React.Fragment>
    )    
}

export default Step2Component