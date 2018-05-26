package test_utils;

import calculator.Vehicle;

import java.util.Date;

public class TestCaseWithMultipleDatesBuilder {

    String nameHeader;
    String nameTail;
    Vehicle actualVehicle;
    int expected;

    public TestCaseWithMultipleDatesBuilder(String nameHeader,
                                            String nameTail,
                                            Vehicle actualVehicle,
                                            int expected) {
        this.nameHeader = nameHeader;
        this.nameTail = nameTail;
        this.actualVehicle = actualVehicle;
        this.expected = expected;
    }

    public static TestCaseWithMultipleDatesBuilder newWithHeader(String nameHeader) {
        return new TestCaseWithMultipleDatesBuilder(nameHeader, null,
                TestData.A_NON_FREE_VEHICLE,
                -1);
    }

    public static TestCaseWithMultipleDatesBuilder newWithoutHeader() {
        return new TestCaseWithMultipleDatesBuilder(null, null,
                TestData.A_NON_FREE_VEHICLE,
                -1);
    }

    public Object[] build(Date[] actualDates) {
        return new Object[]{
                new TestCaseWithMultipleDates(name(),
                        actualDates,
                        actualVehicle,
                        expected)
        };
    }

    public TestCaseWithMultipleDatesBuilder withName(String nameTail) {
        this.nameTail = nameTail;
        return this;
    }

    public TestCaseWithMultipleDatesBuilder withVehicle(Vehicle vehicle) {
        this.actualVehicle = vehicle;
        return this;
    }

    public TestCaseWithMultipleDatesBuilder withExpectedFee(int expected) {
        this.expected = expected;
        return this;
    }

    private String name() {
        if (nameHeader == null) {
            return nameTail;
        } else if (nameTail == null) {
            return nameHeader;
        } else {
            return nameHeader + ": " + nameTail;
        }
    }
}
