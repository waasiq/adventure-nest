import React from "react";
import { motion } from "framer-motion";

const Step6Component: React.FC = () => {
  return (
    <React.Fragment>
      <div className="flex">
        <div className="w-3/5 p-16">
          <motion.h1
            className="text-4xl font-bold mb-4"
            initial={{ opacity: 0, y: -20 }}
            animate={{ opacity: 1, y: 0 }}
            transition={{ duration: 0.5 }}
          >
            Step 2
          </motion.h1>
          <motion.h1
            className="text-6xl font-bold mb-8"
            initial={{ opacity: 0, y: -20 }}
            animate={{ opacity: 1, y: 0 }}
            transition={{ duration: 0.5, delay: 0.3 }}
          >
            Make your place stand out
          </motion.h1>
          <motion.p
            className="text-gray-600 text-xl mb-8"
            initial={{ opacity: 0, y: -20 }}
            animate={{ opacity: 1, y: 0 }}
            transition={{ duration: 0.5, delay: 0.6 }}
          >
            In this step, you{"'"}ll add 5 or more photos. Then, you{"'"}ll create a title and description.
          </motion.p>
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

export default Step6Component;