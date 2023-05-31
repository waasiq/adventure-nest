import React from "react";
import LocalMap from "../../components/others/Map/LocalMap";
import { useNavigate  } from "react-router-dom";
import { motion } from "framer-motion";

const HostPage: React.FC = () => {
  const word = "Make your home Adventurer's nest"
  const letters = word.split("");

  const navigate = useNavigate();
  const redirectHost = () => {
    navigate("/hosting");
  };

  return (
    <React.Fragment>
      <div className="flex my-24 flex-row justify-center items-center">
      <div className="p-14">
        <h1 className="text-center text-3xl font-bold text-black-500">
          {letters.map((letter, index) => (
            <motion.span
              key={index}
              initial={{ opacity: 0, y: -100 }}
              animate={{ opacity: 1, y: 0 }}
              transition={{ delay: index * 0.1 }}
            >
              {letter}
            </motion.span>
          ))}
        </h1>
        <motion.p
          className="text-center text-gray-600"
          initial={{ opacity: 0, y: 100 }}
          animate={{ opacity: 1, y: 0 }}
          transition={{ delay: letters.length * 0.1 }}
        >
          and earn money while you{"'"}re at it
        </motion.p>
      </div>
        <div className="rounded-lg w-96 h-96">
          <LocalMap />
        </div>
      </div>

      <div className="flex justify-center">
        <button
          onClick={redirectHost}
          className="bg-emerald-500 hover:bg-emerald-700 text-white font-bold py-4 px-16 rounded-full"
        >
          Host your home
        </button>
      </div>
    </React.Fragment>
  );
};

export default HostPage;
