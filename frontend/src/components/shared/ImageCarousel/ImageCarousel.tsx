import React, { useEffect } from "react";
import { Carousel } from "react-responsive-carousel";
import "react-responsive-carousel/lib/styles/carousel.min.css";
import { CSSProperties } from "react";

interface ImageCarouselProps {
  images: string[];
  height?: number;
  width?: number;
}

const ImageCarousel: React.FC<ImageCarouselProps> = ({
  images,
  height,
  width,
}) => {
  const containerStyles: CSSProperties = {
    height: height ? `${height}px` : "auto",
    maxHeight: "100%",
    maxWidth: width ? `${width}px` : "100%",
    position: "relative",
    borderRadius: "10px",
    overflow: "hidden",
  };

  const imageStyle: CSSProperties = {
    height: height,
    width: "100%",
    objectFit: "cover",
    borderRadius: "10px", // added border radius here
  };

  useEffect(() => {
    console.log(images);
  }, []);
  return (
    <div style={containerStyles}>
      <Carousel
        autoPlay
        infiniteLoop
        showArrows={true}
        showStatus={false}
        showThumbs={false}
      >
        {images.map((imageUrl, index) => (
          <div key={index}>
            <img
              src={imageUrl}
              alt={`${index}`} 
              style={imageStyle}
              onError={(e) => {
                e.currentTarget.src = "https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=";
              }}
            />
          </div>
        ))}
      </Carousel>
    </div>
  );
};

export default ImageCarousel;
