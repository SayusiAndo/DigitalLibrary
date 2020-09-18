Feature: AddAsync

  As data structure owner and manager
  I need functionality
  Which provides me the ability to
  Build and Manage SourceFormats

  Scenario: Adds a SourceFormat when the newly added SourceFormat doesn't have RootDimensionStructure
    Given there is a SourceFormat without RootDimensionStructure
    When saving SourceFormat
    And it returns with the newly added SourceFormat
    Then the returned SourceFormat is not null
    And the returned SourceFormat's id should not be zero
    And the returned SourceFormat's name equals to the original's name
    And the returned SourceFormat's description equals to the original's description
    And the returned SourceFormat's is active value equals to the original's is active value

  Scenario: Adds a SourceFormat when the newly added SourceFormat has new RootDimensionStructure without dimension
  tree
    Given there is a SourceFormat without RootDimensionStructure
    And there is a DimensionStructure
    And DimensionStructure is RootDimensionStructure of SourceFormat
    When SourceFormat is saved
    And it returns with the newly added SourceFormat
    Then the returned SourceFormat is not null
    And the returned SourceFormat's id should not be zero
    And the returned SourceFormat's name equals to the original's name
    And the returned SourceFormat's description equals to the original's description
    And the returned SourceFormat's is active value equals to the original's is active value
    And the returned SourceFormat's RootDimensionStructure is not null
    And the returned SourceFormat's RootDimensionStructure Id is not zero
    And the returned SourceFormat's RootDimensionStructure's name equals to original's name
    And the returned SourceFormat's RootDimensionStructure's desc equals to original's desc
    And the returned SourceFormat's RootDimensionStructure's is active equals to original's is active

  Scenario: Adds a SourceFormat when RootDimensionStructure an already existing DimensionStructure
    Given there is a SourceFormat without RootDimensionStructure
    And there is a DimensionStructure
    And DimensionStructure is already stored in database
    And DimensionStructure is RootDimensionStructure of SourceFormat
    When SourceFormat is saved
    And it returns with the newly added SourceFormat
    Then the returned SourceFormat is not null
    And the returned SourceFormat's id should not be zero
    And the returned SourceFormat's name equals to the original's name
    And the returned SourceFormat's description equals to the original's description
    And the returned SourceFormat's is active value equals to the original's is active value
    And the returned SourceFormat's RootDimensionStructure is not null
    And the returned SourceFormat's RootDimensionStructure Id is not zero
    And the returned SourceFormat's RootDimensionStructure's name equals to original's name
    And the returned SourceFormat's RootDimensionStructure's desc equals to original's desc
    And the returned SourceFormat's RootDimensionStructure's is active equals to original's is active

  Scenario: Adds a SourceFormat when RootDimensionStructure an already existing DimensionStructure with connection
  to other SourceFormat
    Given there is a SourceFormat without RootDimensionStructure
    And there is a DimensionStructure named as RootDimensionStructure
    And DimensionStructure is already stored in database
    And Dimensionstructure is already has connection to other SourceFormat
    And DimensionStructure is RootDimensionStructure of SourceFormat
    When SourceFormat is saved
    And it returns with the newly added SourceFormat
    Then the returned SourceFormat is not null
    And the returned SourceFormat's id should not be zero
    And the returned SourceFormat's name equals to the original's name
    And the returned SourceFormat's description equals to the original's description
    And the returned SourceFormat's is active value equals to the original's is active value
    And the returned SourceFormat's RootDimensionStructure is not null
    And the returned SourceFormat's RootDimensionStructure Id is not zero
    And the returned SourceFormat's RootDimensionStructure's name equals to original's name
    And the returned SourceFormat's RootDimensionStructure's desc equals to original's desc
    And the returned SourceFormat's RootDimensionStructure's is active equals to original's is active

  Scenario: Adds a SourceFormat when RootDimensionStructure has a single new ChildDimensionStructure
    Given there is a SourceFormat without RootDimensionStructure
    And there is a DimensionStructure named as Root
    And there is a DimensionStructure named as Child1
    And RootDimensionStructure has ChildDimensionStructure at the first level in the DimensionStructure tree
    And RootDimensionStructure is the RootDimensionStructure of SourceFormat
    When SourceFormat is saved
    And it returns with the newly added SourceFormat
    Then the returned SourceFormat is not null
    And the returned SourceFormat's id should not be zero
    And the returned SourceFormat's name equals to the original's name
    And the returned SourceFormat's description equals to the original's description
    And the returned SourceFormat's is active value equals to the original's is active value
    And the returned SourceFormat's RootDimensionStructure is not null
    And the returned SourceFormat's RootDimensionStructure Id is not zero
    And the returned SourceFormat's RootDimensionStructure's name equals to original's name
    And the returned SourceFormat's RootDimensionStructure's desc equals to original's desc
    And the returned SourceFormat's RootDimensionStructure's is active equals to original's is active
    And SF RootDS ChildDS collection length is not zero
    And SF RootDS ChildDS collection has one element
    And SF RootDS ChildDS collection's single element's id isn't zero
    And SF RootDS ChildDS collection's single element's name equals to ChildDS name
    And SF RootDS ChildDS collection's single element's desc equals to ChildDS desc

  Scenario: Adds a SourceFormat when RootDimensionStructure has a single already existing ChildDimensionStructure
    Given there is a SourceFormat without RootDimensionStructure called SF1
    And there is a DimensionStructure named as Root
    And there is a DimensionStructure named as Child1
    And Child1 already stored in the database
    And Root has Child1 at the first level in the DimensionStructure tree
    And Root is the RootDimensionStructure of SourceFormat
    When SourceFormat is saved
    And it returns with the newly added SourceFormat
    Then the returned SourceFormat is not null
    And the returned SourceFormat's id should not be zero
    And the returned SourceFormat's name equals to the original's name
    And the returned SourceFormat's description equals to the original's description
    And the returned SourceFormat's is active value equals to the original's is active value
    And the returned SourceFormat's RootDimensionStructure is not null
    And the returned SourceFormat's RootDimensionStructure Id is not zero
    And the returned SourceFormat's RootDimensionStructure's name equals to original's name
    And the returned SourceFormat's RootDimensionStructure's desc equals to original's desc
    And the returned SourceFormat's RootDimensionStructure's is active equals to original's is active
    And SF RootDS ChildDS collection length is not zero
    And SF RootDS ChildDS collection has one element
    And SF RootDS ChildDS collection's single element's id isn't zero
    And SF RootDS ChildDS collection's single element's id eq to Child1 id
    And SF RootDS ChildDS collection's single element's name equals to Child1 name
    And SF RootDS ChildDS collection's single element's desc equals to Child1 desc

  Scenario: Adds a SourceFormat when RootDimensionStructure has a single already existing ChildDimensionStructure
  with connection to other SourceFormat as RootDimensionStructure
    
    Given there is a SourceFormat without RootDimensionStructure called SF1
    And there is a SourceFormat called SF2
    And SF2 already stored in the database
    And there is a DimensionStructure named as Root
    And there is a DimensionStructure named as Child1
    And Child1 already stored in the database
    And Child1 is RootDS of SF2
    And Root has Child1 at the first level in the DimensionStructure tree
    And Root is the RootDimensionStructure of SourceFormat
    
    When SourceFormat is saved
    And it returns with the newly added SourceFormat
    
    Then the returned SourceFormat is not null
    And the returned SourceFormat's id should not be zero
    And the returned SourceFormat's name equals to the original's name
    And the returned SourceFormat's description equals to the original's description
    And the returned SourceFormat's is active value equals to the original's is active value
    And the returned SourceFormat's RootDimensionStructure is not null
    And the returned SourceFormat's RootDimensionStructure Id is not zero
    And the returned SourceFormat's RootDimensionStructure's name equals to original's name
    And the returned SourceFormat's RootDimensionStructure's desc equals to original's desc
    And the returned SourceFormat's RootDimensionStructure's is active equals to original's is active
    And SF RootDS ChildDS collection length is not zero
    And SF RootDS ChildDS collection has one element
    And SF RootDS ChildDS collection's single element's id isn't zero
    And SF RootDS ChildDS collection's single element's id eq to Child1 id
    And SF RootDS ChildDS collection's single element's name equals to Child1 name
    And SF RootDS ChildDS collection's single element's desc equals to Child1 desc
    And SF RootDS ChildDS collection's single element's has SF2 where it is RootDS

  Scenario: Adds a SourceFormat when RootDimensionStructure has a single already existing ChildDimensionStructure
  with connection to other SourceFormat as ChildDimensionStructure

    Given there is a SourceFormat without RootDimensionStructure called SF1
    And there is a DimensionStructure named as Root
    And there is a DimensionStructure named as Child1
    And there is a SourceFormat called SF2
    And there is a DimensionStructure called SF2Root
    And SF2Root is RootDS of SF2
    And SF2 already stored in the database
    And Child1 already stored in the database
    And Child1 is Child of SF2Root
    And Root has Child1 at the first level in the DimensionStructure tree
    And Root is the RootDimensionStructure of SourceFormat

    When SourceFormat is saved
    And it returns with the newly added SourceFormat

    Then the returned SourceFormat is not null
    And the returned SourceFormat's id should not be zero
    And the returned SourceFormat's name equals to the original's name
    And the returned SourceFormat's description equals to the original's description
    And the returned SourceFormat's is active value equals to the original's is active value
    And the returned SourceFormat's RootDimensionStructure is not null
    And the returned SourceFormat's RootDimensionStructure Id is not zero
    And the returned SourceFormat's RootDimensionStructure's name equals to original's name
    And the returned SourceFormat's RootDimensionStructure's desc equals to original's desc
    And the returned SourceFormat's RootDimensionStructure's is active equals to original's is active
    And SF RootDS ChildDS collection length is not zero
    And SF RootDS ChildDS collection has one element
    And SF RootDS ChildDS collection's single element's id isn't zero
    And SF RootDS ChildDS collection's single element's id eq to Child1 id
    And SF RootDS ChildDS collection's single element's name equals to Child1 name
    And SF RootDS ChildDS collection's single element's desc equals to Child1 desc
    And SF RootDS ChildDS collection's single element's has other connections towards SF2Root
    And SF2Root has Child1 as ChildDimensionStructure

  Scenario: Adds a SourceFormat when RootDimensionStructure has multiple ChildDimensionStructures and one of them is
  new the other one existing without connections

  Scenario: Adds a SourceFormat when RootDimensionStructure has multiple ChildDimensionStructures and one of them is
  new the other one existing with connection to other SourceFormat as RootDimensionStructure

  Scenario: Adds a SourceFormat when RootDimensionStructure has multiple ChildDimensionStructures and one of them is
  new the other one existing with connection to other SourceFormat as ChildDimensionStructure

  Scenario: Adds a SourceFormat when RootDimensionStructure has a single ChildDimensionStructure on the second level as new

  Scenario: Adds a SourceFormat when RootDimensionStructure has a single ChildDimensionStructure on the second level without
  connections

  Scenario: Adds a SourceFormat when RootDimensionStructure has a single ChildDimensionStructure on the second level with
  connection to other SourceFormats as RootDimensionStructure

  Scenario: Adds a SourceFormat when RootDimensionStructure has a single ChildDimensionStructure on the second level with
  connection to other SourceFormats as ChildDimensionStructure

  Scenario: Adds a SourceFormat when RootDimensionStructure has multiple ChildDimensionStructures on the second level
  and both of them are new

  Scenario: Adds a SourceFormat when RootDimensionStructure has multiple ChildDimensionStructures on the second level
  and one of them is new the other one has already existing

  Scenario: Adds a SourceFormat when RootDimensionStructure has multiple ChildDimensionStructures on the second level
  and one of them is new the other one has already existing with connection to other SourceFormat as
  ChildDimensionStructure

  Scenario: Adds a SourceFormat when RootDimensionStructure has multiple ChildDimensionStructures on the second level
  and one of them is new the other one has already existing with connection to other SourceFormat as
  RootDimensionStructure

  Scenario: Adds a SourceFormat when RootDimensionStructure has multiple ChildDimensionStructures on the second level
  and one of them is new the other one has already existing with connection to other SourceFormat as
  ChildDimensionStructure

  Scenario: Adds a SourceFormat when RootDimensionStructure has multiple ChildDimensionStructures on the second level
  and both of them existing

  Scenario: Adds a SourceFormat when RootDimensionStructure has multiple ChildDimensionStructures on the second level
  and both of them existing one of them has connection to other SourceFormat as ChildDimensionStructure and the other
  one has connection to other SourceFormat as RootDimensionStructure

  Scenario: Adds a SourceFormat when RootDimensionStructure has a single ChildDimensionStructure on the third level as
  new

  Scenario: Adds a SourceFormat when RootDimensionStructure has a single ChildDimensionStructure on the third level
  without   connections

  Scenario: Adds a SourceFormat when RootDimensionStructure has a single ChildDimensionStructure on the third level with
  connection to other SourceFormats as RootDimensionStructure

  Scenario: Adds a SourceFormat when RootDimensionStructure has a single ChildDimensionStructure on the third level with
  connection to other SourceFormats as ChildDimensionStructure

  Scenario: Adds a SourceFormat when RootDimensionStructure has multiple ChildDimensionStructures on the third level
  and both of them are new

  Scenario: Adds a SourceFormat when RootDimensionStructure has multiple ChildDimensionStructures on the third level
  and one of them is new the other one has already existing

  Scenario: Adds a SourceFormat when RootDimensionStructure has multiple ChildDimensionStructures on the third level
  and one of them is new the other one has already existing with connection to other SourceFormat as
  ChildDimensionStructure

  Scenario: Adds a SourceFormat when RootDimensionStructure has multiple ChildDimensionStructures on the third level
  and one of them is new the other one has already existing with connection to other SourceFormat as
  RootDimensionStructure

  Scenario: Adds a SourceFormat when RootDimensionStructure has multiple ChildDimensionStructures on the third level
  and one of them is new the other one has already existing with connection to other SourceFormat as
  ChildDimensionStructure

  Scenario: Adds a SourceFormat when RootDimensionStructure has multiple ChildDimensionStructures on the third level
  and both of them existing

  Scenario: Adds a SourceFormat when RootDimensionStructure has multiple ChildDimensionStructures on the third level
  and both of them existing one of them has connection to other SourceFormat as ChildDimensionStructure and the other
  one has connection to other SourceFormat as RootDimensionStructure

  Scenario: Adds a SourceFormat when RootDimensionStructure has multiple ChildDimensionStructures on the first
  level and both of them are new and there are multiple DimensionStructures on the second level both of them are
  new and multiple DimensionStructures on the third level both of them are new

  Scenario: Adds a SourceFormat when RootDimensionStructure has multiple ChildDimensionStructures on the first
  level and both of them are existing and there are multiple DimensionStructures on the second level both of them are
  existing and multiple DimensionStructures on the third level both of them are existing

  Scenario: Adds a SourceFormat when RootDimensionStructure has multiple ChildDimensionStructures on the first
  level and both of them have connection to other SourceFormats as ChildDimensions and there are multiple
  DimensionStructures on the second level both of them have connection to other SourceFormats as
  ChildDimensionStructure and multiple DimensionStructures on the third level both of them have connection to other
  SourceFormat as ChildDimensionStructure