import React from "react";

interface CheckboxProps {
  label: string;
  checked: boolean;
  onChange?: (checked: boolean) => void;
}

const Checkbox: React.FC<CheckboxProps> = ({ label, checked, onChange }) => {
  const handleChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    onChange?.(event.target.checked);
  };

  return (
    <div className="flex items-center border-b border-gray-200 mx-26 px-4 py-7 justify-between">
      <label className="text-xl px-2">{label}</label>
      <input
        type="checkbox"
        checked={checked}
        onChange={handleChange}
        className="form-checkbox text-indigo-500 h-5 w-5"
      />
    </div>
  );
};

export default Checkbox;
