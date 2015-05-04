class SuperClass

  attr_accessor :field

  # ruby doesn't support overloading, but can
  # be emulated by providing default parameter
  # values
  def initialize(string = 'default')
    self.field = string
  end

end
