import React from "react";
import Footer from "../components/shared/Footer/Footer";

const HelpPage: React.FC = () => {
  return (
    <React.Fragment>
      <body className="flex flex-col min-h-screen">
        <div className="flex-grow max-w-7xl mx-auto px-4 sm:px-6 lg:px-8">
          <div className="max-w-3xl mx-auto">
            <h1 className="text-4xl font-bold text-gray-900 mb-8">
              Help for Guests
            </h1>
            <div className="grid grid-cols-1 md:grid-cols-2 gap-8">
              <div>
                <h2 className="text-2xl font-bold text-gray-900 mb-4">
                  Booking a Place to Stay
                </h2>
                <ul className="list-disc list-inside">
                  <li className="mb-2">
                    <a
                      href="#"
                      className="text-lg font-medium text-indigo-600 hover:text-indigo-900"
                    >
                      How do I search for a place to stay?
                    </a>
                  </li>
                  <li className="mb-2">
                    <a
                      href="#"
                      className="text-lg font-medium text-indigo-600 hover:text-indigo-900"
                    >
                      How do I book a place to stay?
                    </a>
                  </li>
                  <li className="mb-2">
                    <a
                      href="#"
                      className="text-lg font-medium text-indigo-600 hover:text-indigo-900"
                    >
                      What payment methods are accepted on Adventure Nest?
                    </a>
                  </li>
                </ul>
              </div>
              <div>
                <h2 className="text-2xl font-bold text-gray-900 mb-4">
                  During Your Stay
                </h2>
                <ul className="list-disc list-inside">
                  <li className="mb-2">
                    <a
                      href="#"
                      className="text-lg font-medium text-indigo-600 hover:text-indigo-900"
                    >
                      How do I contact my host?
                    </a>
                  </li>
                  <li className="mb-2">
                    <a
                      href="#"
                      className="text-lg font-medium text-indigo-600 hover:text-indigo-900"
                    >
                      What should I do if there{`'`}s a problem with my stay?
                    </a>
                  </li>
                  <li className="mb-2">
                    <a
                      href="#"
                      className="text-lg font-medium text-indigo-600 hover:text-indigo-900"
                    >
                      How do I extend my stay?
                    </a>
                  </li>
                </ul>
              </div>
            </div>
          </div>
        </div>

        <Footer />
      </body>
    </React.Fragment>
  );
};

export default HelpPage;
