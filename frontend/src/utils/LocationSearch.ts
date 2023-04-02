import axios from 'axios';

interface GeoCodeData {
  latt: string;
  longt: string;
}

async function getGeoCodeData(address: string): Promise<GeoCodeData | null> {
  const url = `https://geocode.xyz/${address}?json=1&auth=137454449552198334490x96116`;
  try {
    const response = await axios.get<GeoCodeData>(url);
    return response.data;
  } catch (error) {
    console.error(error);
    return null;
  }
}

export default getGeoCodeData;
