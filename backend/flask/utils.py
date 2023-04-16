from cloudinary.uploader import upload
from cloudinary.utils import cloudinary_url
import cloudinary

from dotenv import load_dotenv
load_dotenv()

import os
API_KEY = os.getenv("API_KEY")
API_SECRET = os.getenv("API_SECRET")


cloudinary.config(
  cloud_name = "ddjnynylb",
  api_key = API_KEY,
  api_secret = API_SECRET,
  secure = True
)

# upload("https://upload.wikimedia.org/wikipedia/commons/a/ae/Olympic_flag.jpg", public_id="olympic_flag")
# url, options = cloudinary_url("olympic_flag", width=100, height=150, crop="fill")
# print(url, options)