import "react-responsive-carousel/lib/styles/carousel.min.css"; // requires a loader
import { Carousel } from 'react-responsive-carousel';

import Logo from '../../../imgs/logos/logo.png';

const ImageCarousel: React.FC = () => {
    return (
        <Carousel>
                <div>
                    <img src={Logo} />
                </div>
                <div>
                    <img src={Logo} />
                </div>
                <div>
                    <img src={Logo} />
                </div>
            </Carousel>
    )
}

export default ImageCarousel
