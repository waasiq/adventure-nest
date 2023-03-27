import React from 'react';
import Datepicker from './Datepicker';
import UserDropdown from './UserDropdown';
import Logo from '../../../imgs/logos/logo.png';

const Navbar: React.FC = () => {
    return (
      <nav className="bg-gray-800">
        <div className="mx-auto px-4 sm:px-6 lg:px-8">
          <div className="flex items-center justify-between h-16">
            <div className="flex-shrink-0">
              <img
                className="h-8 w-8"
                src={Logo}
                alt="Workflow"
              />
            </div>
            <div className="hidden md:block">           
              <div className="ml-10 flex items-baseline space-x-4">
                <a
                  href="#"
                  className="text-gray-300 hover:bg-gray-700 hover:text-white px-3 py-2 rounded-md text-sm font-medium"
                >
                  Host an Adventurer
                </a>

                <a
                  href="#"
                  className="text-gray-300 hover:bg-gray-700 hover:text-white px-3 py-2 rounded-md text-sm font-medium"
                >
                  <UserDropdown />
                </a>
              </div>
            </div>
          </div>
        </div>
      </nav>
    );
}

export default Navbar