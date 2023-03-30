import React from 'react';

const Step1Component:React.FC = () => {
    return (    
        <React.Fragment>
            <div className="flex">
                <div className="w-3/5 p-16">
                    <h1 className="text-4xl font-bold mb-4">Step 1</h1>
                    <h1 className="text-6xl font-bold mb-8">Tell us about your place</h1>
                    <p className="text-gray-600 text-xl mb-8">
                        In this step, we'll ask you which type of property you have and if guests will book the entire place or just a room. Then let us know the location and how many guests can stay.
                    </p>
                </div>
                <div className="w-2/5">
                    <video className="w-full h-full" autoPlay crossOrigin="anonymous" playsInline preload="auto" muted>
                        <source src="https://stream.media.muscache.com/zFaydEaihX6LP01x8TSCl76WHblb01Z01RrFELxyCXoNek.mp4?v_q=high" />
                    </video>
                </div>
            </div>
        </React.Fragment> 
    )    
}

export default Step1Component