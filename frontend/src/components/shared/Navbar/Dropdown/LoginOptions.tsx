import React, { useContext, useState } from 'react';
import { CurrentUserContext } from '../../../../context/CurrentUserContext';
import Login from "../../../../utils/Login";
import Modal from "../../Modal/Modal";

const LogInOptions:React.FC = () => {
    const { user } = useContext(CurrentUserContext);
    const [logInModal, setLogInModal] = useState(false);
    const openLogInModal = () => { setLogInModal(!logInModal) }

    return (    
        <React.Fragment>
            {!user && (
                <React.Fragment>
                <a
                href="#"
                className="block px-4 py-2 text-sm text-gray-700 hover:bg-gray-100 hover:text-gray-900"
                role="menuitem"
                onClick={openLogInModal}
                >
                Log In
                </a>
            
                { 
                    logInModal && 
                    <Modal 
                    open={logInModal} 
                    title={'Log In'} 
                    buttonTitle={'Log In'}
                    children={<Login />}
                    /> 
                }

                <a
                    href="#"
                    className="block px-4 py-2 text-sm text-gray-700 hover:bg-gray-100 hover:text-gray-900"
                    role="menuitem"
                    >
                    Sign Up
                </a>
            </React.Fragment>
        )}
        </React.Fragment>
    )    
}

export default LogInOptions