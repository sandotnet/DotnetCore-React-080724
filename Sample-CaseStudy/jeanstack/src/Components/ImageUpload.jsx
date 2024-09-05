import React, { useState } from "react";
// import cloudinary from "cloudinary";
import { Cloudinary } from "@cloudinary/url-gen";

const ImageUpload = ({ setImage, image }) => {
  const [isLoading, setIsLoading] = useState(false);
  const [error, setError] = useState(null);

  const cld = new Cloudinary({ cloud: { cloudName: "dyywwmbsl" } });
  const handleImageChange = async (e) => {
    setIsLoading(true);
    setError(null);

    try {
      const file = e.target.files[0];

      if (!file) {
        setError("Please select an image file to upload.");
        return;
      }

      const formData = new FormData();
      formData.append("file", file);
      formData.append("upload_preset", "hbpzztue"); // Replace with your upload preset

      const response = await fetch(
        "https://api.cloudinary.com/v1_1/dyywwmbsl/upload",
        {
          method: "POST",
          body: formData,
        }
      );

      const data = await response.json();
      if (response.ok) {
        console.log("Image uploaded successfully:", data);
        console.log(data.secure_url);
        setImage(data.secure_url); // Update image URL in state
      } else {
        setError(data.error.message || "Image upload failed.");
      }
    } catch (error) {
      console.error("Image upload failed:", error);
      setError("An error occurred during upload. Please try again.");
    } finally {
      setIsLoading(false);
    }
  };

  return (
    <div className="image-upload">
      <label htmlFor="image">Upload Image</label>
      <input type="file" accept="image/*" onChange={handleImageChange} />
      {isLoading && <p>Uploading...</p>}
      {error && <p style={{ color: "red" }}>{error}</p>}
      {image && (
        <div>
          <img src={image} alt="Uploaded" style={{ maxWidth: "50%" }} />
        </div>
      )}
    </div>
  );
};

export default ImageUpload;
