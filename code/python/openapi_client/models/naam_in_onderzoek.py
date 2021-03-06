# coding: utf-8

"""
    BRP historie bevragen

    API voor het zoeken en raadplegen van historische verblijfplaatsen, partners, nationaliteiten en verblijfstitels uit de BRP (inclusief de RNI).  Zie de [Functionele documentatie](https://github.com/VNG-Realisatie/Haal-Centraal-BRP-historie-bevragen/tree/v1.0.0/features) voor nadere toelichting.   # noqa: E501

    The version of the OpenAPI document: 0.0.1 (develop)
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six

from openapi_client.configuration import Configuration


class NaamInOnderzoek(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'geslachtsnaam': 'bool',
        'voornamen': 'bool',
        'voorvoegsel': 'bool',
        'datum_ingang_onderzoek': 'DatumOnvolledig'
    }

    attribute_map = {
        'geslachtsnaam': 'geslachtsnaam',
        'voornamen': 'voornamen',
        'voorvoegsel': 'voorvoegsel',
        'datum_ingang_onderzoek': 'datumIngangOnderzoek'
    }

    def __init__(self, geslachtsnaam=None, voornamen=None, voorvoegsel=None, datum_ingang_onderzoek=None, local_vars_configuration=None):  # noqa: E501
        """NaamInOnderzoek - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._geslachtsnaam = None
        self._voornamen = None
        self._voorvoegsel = None
        self._datum_ingang_onderzoek = None
        self.discriminator = None

        if geslachtsnaam is not None:
            self.geslachtsnaam = geslachtsnaam
        if voornamen is not None:
            self.voornamen = voornamen
        if voorvoegsel is not None:
            self.voorvoegsel = voorvoegsel
        if datum_ingang_onderzoek is not None:
            self.datum_ingang_onderzoek = datum_ingang_onderzoek

    @property
    def geslachtsnaam(self):
        """Gets the geslachtsnaam of this NaamInOnderzoek.  # noqa: E501


        :return: The geslachtsnaam of this NaamInOnderzoek.  # noqa: E501
        :rtype: bool
        """
        return self._geslachtsnaam

    @geslachtsnaam.setter
    def geslachtsnaam(self, geslachtsnaam):
        """Sets the geslachtsnaam of this NaamInOnderzoek.


        :param geslachtsnaam: The geslachtsnaam of this NaamInOnderzoek.  # noqa: E501
        :type: bool
        """

        self._geslachtsnaam = geslachtsnaam

    @property
    def voornamen(self):
        """Gets the voornamen of this NaamInOnderzoek.  # noqa: E501


        :return: The voornamen of this NaamInOnderzoek.  # noqa: E501
        :rtype: bool
        """
        return self._voornamen

    @voornamen.setter
    def voornamen(self, voornamen):
        """Sets the voornamen of this NaamInOnderzoek.


        :param voornamen: The voornamen of this NaamInOnderzoek.  # noqa: E501
        :type: bool
        """

        self._voornamen = voornamen

    @property
    def voorvoegsel(self):
        """Gets the voorvoegsel of this NaamInOnderzoek.  # noqa: E501


        :return: The voorvoegsel of this NaamInOnderzoek.  # noqa: E501
        :rtype: bool
        """
        return self._voorvoegsel

    @voorvoegsel.setter
    def voorvoegsel(self, voorvoegsel):
        """Sets the voorvoegsel of this NaamInOnderzoek.


        :param voorvoegsel: The voorvoegsel of this NaamInOnderzoek.  # noqa: E501
        :type: bool
        """

        self._voorvoegsel = voorvoegsel

    @property
    def datum_ingang_onderzoek(self):
        """Gets the datum_ingang_onderzoek of this NaamInOnderzoek.  # noqa: E501


        :return: The datum_ingang_onderzoek of this NaamInOnderzoek.  # noqa: E501
        :rtype: DatumOnvolledig
        """
        return self._datum_ingang_onderzoek

    @datum_ingang_onderzoek.setter
    def datum_ingang_onderzoek(self, datum_ingang_onderzoek):
        """Sets the datum_ingang_onderzoek of this NaamInOnderzoek.


        :param datum_ingang_onderzoek: The datum_ingang_onderzoek of this NaamInOnderzoek.  # noqa: E501
        :type: DatumOnvolledig
        """

        self._datum_ingang_onderzoek = datum_ingang_onderzoek

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, NaamInOnderzoek):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, NaamInOnderzoek):
            return True

        return self.to_dict() != other.to_dict()
