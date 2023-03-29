import React from 'react';
import { FaFacebookF, FaTwitter, FaInstagram, FaYoutube } from 'react-icons/fa';


const Footer:React.FC = () => {
    return (
      <footer className="bg-gray-100 text-black-300">
        <div className="max-w-7xl mx-auto py-8 px-4 sm:px-6 lg:px-8 flex flex-col md:flex-row justify-between">
            <div className="mb-8 md:mb-0">
            <h3 className="text-lg font-medium">About Adventure Nest</h3>
            <ul className="mt-4">
                <li className="my-2"><a href="#">How Adventure Nest works</a></li>
                <li className="my-2"><a href="#">Newsroom</a></li>
                <li className="my-2"><a href="#">Investors</a></li>
                <li className="my-2"><a href="#">Adventure Nest Plus</a></li>
                <li className="my-2"><a href="#">Adventure Nest Luxe</a></li>
            </ul>
            </div>
            <div className="mb-8 md:mb-0">
            <h3 className="text-lg font-medium">Community</h3>
            <ul className="mt-4">
                <li className="my-2"><a href="#">Diversity & Belonging</a></li>
                <li className="my-2"><a href="#">Accessibility</a></li>
                <li className="my-2"><a href="#">Adventure Nest Associates</a></li>
                <li className="my-2"><a href="#">Frontline Stays</a></li>
                <li className="my-2"><a href="#">Guest Referrals</a></li>
            </ul>
            </div>
            <div className="mb-8 md:mb-0">
            <h3 className="text-lg font-medium">Host</h3>
            <ul className="mt-4">
                <li className="my-2"><a href="#">Host your home</a></li>
                <li className="my-2"><a href="#">Host an Online Experience</a></li>
                <li className="my-2"><a href="#">Host an Experience</a></li>
                <li className="my-2"><a href="#">Responsible hosting</a></li>
                <li className="my-2"><a href="#">Resource Center</a></li>
            </ul>
            </div>
            <div>
            <h3 className="text-lg font-medium">Connect with us</h3>
            <ul className="mt-4 flex space-x-4">
                <li><a href="#"><FaFacebookF className="w-6 h-6" /></a></li>
                <li><a href="#"><FaTwitter className="w-6 h-6" /></a></li>
                <li><a href="#"><FaInstagram className="w-6 h-6" /></a></li>
                <li><a href="#"><FaYoutube className="w-6 h-6" /></a></li>
            </ul>
            </div>
        </div>
        <div className="bg-gray-100  py-4 text-center">
            <p className="text-sm text-black-300">&copy; {new Date().getFullYear()} Adventure Nest, Inc. All rights reserved.</p>
        </div>
      </footer>
    )
}

export default Footer
