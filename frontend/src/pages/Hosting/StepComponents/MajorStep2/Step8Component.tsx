import React from "react";

const Step8Component: React.FC = () => {
  return (
    <React.Fragment>
      <div className="flex">
        <div className="w-3/5 p-16">
          <h1 className="text-4xl font-bold mb-4">Step 2</h1>
          <h1 className="text-6xl font-bold mb-8">Make your place stand out</h1>
          <p className="text-gray-600 text-xl mb-8">
            In this step, you{"'"}ll add 5 or more photos.
            Then, you{"'"}ll create a title and description.
          </p>
        </div>
        <div className="w-2/5">
          <video
            className="w-full h-full"
            autoPlay
            crossOrigin="anonymous"
            playsInline
            preload="auto"
            muted
          >
            <source src="https://stream.media.muscache.com/zFaydEaihX6LP01x8TSCl76WHblb01Z01RrFELxyCXoNek.mp4?v_q=high" />
          </video>
        </div>
      </div>
    </React.Fragment>
  );
};

export default Step8Component;
