require 'spec_helper'

describe "SubClass's contstructors" do

  it 'inherits from SuperClass without parameters' do
    subclass = SubClass.new
    expect(subclass.field).to eq 'default'
  end

  it 'inherits from SuperClass with parameters' do
    subclass = SubClass.new('value')
    expect(subclass.field).to eq 'value'
  end
end
