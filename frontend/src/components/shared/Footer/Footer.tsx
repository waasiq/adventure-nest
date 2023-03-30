import React from "react";
import { FaFacebookF, FaTwitter, FaInstagram, FaYoutube } from "react-icons/fa";

const Footer: React.FC = () => {
  return (
    <footer className="mt-auto bg-gray-100 text-black-300">
      <div className="max-w-7xl mx-auto py-8 px-4 sm:px-6 lg:px-8 flex flex-col md:flex-row justify-between">
        <div className="mb-8 md:mb-0">
          <h3 className="text-lg font-medium">About Adventure Nest</h3>
          <ul className="mt-4">
            <li className="my-2">
              <button>How Adventure Nest works</button>
            </li>
            <li className="my-2">
              <button>Newsroom</button>
            </li>
            <li className="my-2">
              <button>Investors</button>
            </li>
            <li className="my-2">
              <button>Adventure Nest Plus</button>
            </li>
            <li className="my-2">
              <button>Adventure Nest Luxe</button>
            </li>
          </ul>
        </div>
        <div className="mb-8 md:mb-0">
          <h3 className="text-lg font-medium">Community</h3>
          <ul className="mt-4">
            <li className="my-2">
              <button>Diversity & Belonging</button>
            </li>
            <li className="my-2">
              <button>Accessibility</button>
            </li>
            <li className="my-2">
              <button>Adventure Nest Associates</button>
            </li>
            <li className="my-2">
              <button>Frontline Stays</button>
            </li>
            <li className="my-2">
              <button>Guest Referrals</button>
            </li>
          </ul>
        </div>
        <div className="mb-8 md:mb-0">
          <h3 className="text-lg font-medium">Host</h3>
          <ul className="mt-4">
            <li className="my-2">
              <button>Host your home</button>
            </li>
            <li className="my-2">
              <button>Host an Online Experience</button>
            </li>
            <li className="my-2">
              <button>Host an Experience</button>
            </li>
            <li className="my-2">
              <button>Responsible hosting</button>
            </li>
            <li className="my-2">
              <button>Resource Center</button>
            </li>
          </ul>
        </div>
        <div>
          <h3 className="text-lg font-medium">Connect with us</h3>
          <ul className="mt-4 flex space-x-4">
            <li>
              <button>
                <FaFacebookF className="w-6 h-6" />
              </button>
            </li>
            <li>
              <button>
                <FaTwitter className="w-6 h-6" />
              </button>
            </li>
            <li>
              <button>
                <FaInstagram className="w-6 h-6" />
              </button>
            </li>
            <li>
              <button>
                <FaYoutube className="w-6 h-6" />
              </button>
            </li>
          </ul>
        </div>
      </div>
      <div className="bg-gray-100  py-4 text-center">
        <p className="text-sm text-black-300">
          &copy; {new Date().getFullYear()} Adventure Nest, Inc. All rights
          reserved.
        </p>
      </div>
    </footer>
  );
};

export default Footer;
